/*
   Filename:        BlasterSetup.c                                                          
   Date:            November 18, 2025                                                    
   File Version:    1                                                               
   Author:          Andrew Keller                                                       
   Company:         Idaho State University					    
   Description:     Laser Arcade Blaster Subroutines Source Code File
*/

#include <xc.h>
#include "BlasterSubroutines.h"
#include "BlasterSetup.h"

extern void CHARGE_EEPROM(void);

void ConfigurePlayerLED(unsigned char Red, unsigned char Green, unsigned char Blue){
        
    TRISCbits.TRISC2 = 1; //disable PWM Output for CCP1 setup
    TRISCbits.TRISC1 = 1; //disable PWM Output for CCP2 setup
    TRISCbits.TRISC6 = 1; //disable PWM Output for CCP3 setup
    
    //CCP1 = Red
    //CCP2 = Blue
    //CCP3 = Green
    CCP1CON = 0x0C; //set CCP1 to PWM Mode
    CCP2CON = 0x0C; //set CCP2 to PWM Mode
    CCP3CON = 0x0C; //set CCP3 to PWM Mode
    
    //set pulse width
    CCPR1L = Red; //red player color
    CCPR2L = Blue; //blue player color
    CCPR3L = Green; //green player color
    
    T2CON = 0b00000001; //4x pre-scaler on Timer 2
    PR2 = 0xFF; //Set PR2
    
    TRISCbits.TRISC2 = 0; //enable PWM Output
    TRISCbits.TRISC1 = 0; //enable PWM Output
    TRISCbits.TRISC6 = 0; //enable PWM Output
    T2CONbits.TMR2ON = 1;
}

unsigned char LoadFromEEPROM(unsigned char address){
    EEADRL = address;
    EECON1bits.CFGS = 0; //deselect config space
    EECON1bits.EEPGD = 0; //configure to read from data and not program memory
    EECON1bits.RD = 1; //read from EEPROM    
    return EEDATL;
}

void SaveToEEPROM(unsigned char address, unsigned char data){
    EEADRL = address; //change EEPROM address
    EEDATL = data; //set EEPROM data
    EECON1bits.CFGS = 0; //deselect config space
    EECON1bits.EEPGD = 0; //configure to read from data and not program memory
    EECON1bits.WREN = 1; //enable writes
    CHARGE_EEPROM();
    EECON1bits.WREN = 0; //disable writes
    while (EECON1bits.WR == 1){} //wait for EEPROM to finish writing
}

void SingleFireBlaster(unsigned char PlayerNum){
    PORTA = 0b01111101; //enable speaker, trigger audio TRIG1
    while (AudioActivity == 1){} //wait for audio to start
    PORTA = 0b11111111; //enable speaker, extend solenoid, disable audio triggers
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = 0x3C; //send ASCII <
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = PlayerNum; //transmit the player number
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = 0x3E; //send ASCII >
    __delay_ms(10); //delay 100 ms
    PORTA = 0b01111111; //enable speaker, retract solenoid, disable audio triggers
    while (AudioActivity == 0){} //wait for audio to stop
    __delay_ms(100); //delay 100ms
    PORTA = 0b00111111; //enable speaker, retract solenoid, disable audio triggers
}

void FireBlaster(unsigned char PlayerNum){
    while (AudioActivity == 1){} //wait for audio to start
    PORTA = 0b11111101; //keep speaker enabled, extend solenoid, leave audio triggered
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = 0x3C; //send ASCII <
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = PlayerNum; //transmit the player number
    while (TXSTAbits.TRMT == 0){} //wait for TX to be available
    TXREG = 0x3E; //send ASCII >
    __delay_ms(10); //delay 10 ms
    PORTA = 0b01111101; //keep speaker enabled, retract solenoid, leave audio triggered
    __delay_ms(100); //delay 100ms to wait for audio to finish playing
}

/*
volatile unsigned char SENDLEDRED __at(0x20);
volatile unsigned char SENDLEDBLUE __at(0x21);
volatile unsigned char SENDLEDGREEN __at(0x22);
volatile unsigned char LEDNUMBER __at(0x23);
volatile unsigned char LEDCOUNTER __at(0x24);

extern void SENDLED(void);







void ConfigureCCP1(void){
    TRISCbits.TRISC2 = 1; //disable PWM Output for CCP1 setup
    CCP1CON = 0x0C; //set CCP1 to PWM Mode
    CCPR1L = 0x00; //PW for 50%DC at 38kHz
    T2CON = 0b00000011; //64x pre-scaler
    PR2 = 0xFF; //Set PR2 to 25 for 38kHz period
    TRISCbits.TRISC2 = 0; //enable PWM Output for CCP1
    T2CONbits.TMR2ON = 1;
}

void ConfigurePSMC1(void){
    PSMC1PRH = 0x00; //Set the period to 20ms
    PSMC1PRL = 0x68;
    PSMC1DCH = 0x00; //set the falling edge to centered servo
    PSMC1DCL = 0x34;
    PSMC1PHH = 0x00; //set the rising edge to always 0
    PSMC1PHL = 0x00;
    PSMC1CLK = 0b00110000; //Set PSMC1 clock to FOSC/8 (4MHz)
    PSMC1STR0 = 0x01; //enable PSMC output 1
    PSMC1POL = 0x00; //polarity is active high
    PSMC1OEN = 0x01; //output enabled A
    PSMC1PRS = 0x01; //only time base causes a period event
    PSMC1PHS = 0x01; //only time base causes a rising edge event
    PSMC1DCS = 0x01; //only time base causes a falling edge event
    PSMC1MDL = 0b11101000; //PSMC1 is modulated by active low signal at PSMC1IN
    PSMC1CON = 0b11000000; //enable PSMC and load changes in
}

void ConfigureUART(void){
    SPBRGH = 0x03; //UART BAUD RATE OF 2400 W/ 32MHz OSCILLATOR
    SPBRGL = 0x40;
    BAUDCON = 0b00001000; //16-BIT BAUD RATE GENERATOR
    RCSTA = 0b10010000; //ENABLE UART PORT, ENABLE RECEIVER
    TXSTA = 0b00100000; //ENABLE TRANSMITTER, ASYNCHRONOUS
}

void ConfigureADC(void){
    ADCON0 = 0b11000001; //Enable ADC for AN0, 10-bit result
    ADCON1 = 0b00010001; //FOSC/8 ADC clock, VREF+ on RA3, VREF- on VSS
    ADCON2 = 0x00; //clear everything
}

void ConfigureInterrupts(void){
    INTCON = 0b01000000;
    PIE1 = 0b01000000;
    PIE2 = 0x00;
    PIE3 = 0x00;
    PIE4 = 0x00;
    PIR1 = 0x00;
    PIR2 = 0x00;
    PIR3 = 0x00;
    PIR4 = 0x00;
    INTCONbits.GIE = 1;
}
 */