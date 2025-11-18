/*
   Filename:        BlasterSetup.c                                                          
   Date:            November 18, 2025                                                    
   File Version:    1                                                               
   Author:          Andrew Keller                                                       
   Company:         Idaho State University					    
   Description:     Laser Arcade Blaster Setup Source Code File
*/

#include <xc.h>
#include "BlasterSetup.h"

void Setup_ConfigureOscillator(void){
    OSCCON = 0b11101000; //Enable Internal osc, set to 4MHz
    CLKRCON = 0x00; //Disable Clock Reference
}

void Setup_ConfigureOptions(void){
    OPTION_REG = 0b10000000; //disable weak pull-ups
}

void Setup_ConfigurePinFunctions(void){
    APFCON1 = 0b00000110; //TX on RB6, RX on RB7
    APFCON2 = 0x00;
}

void Setup_ConfigurePortA(void){
    PORTA = 0x00; //clear port A
    LATA = 0X00; 
    TRISA = 0b00000000; //porta as outputs
    ANSELA = 0b00000000; //porta as digital I/O
    WPUA = 0x00; //disable all pull-ups
    ODCONA = 0x00; //disable open drain
    SLRCONA = 0x00; //set maximum slew rate
    INLVLA = 0x00; //set the port to TTL levels
    IOCAP = 0x00; //disable rising edge interrupts
    IOCAN = 0x00; //disable falling edge interrupts
}

void Setup_ConfigurePortB(void){
    PORTB = 0x00; //clear port B
    LATB = 0x00; 
    TRISB = 0b10111111; //portb as inputs, RB6 as output
    ANSELB = 0x00; //portb as digital I/O
    WPUB = 0x00; //disable all pull-ups
    ODCONB = 0x00; //disable open drain
    SLRCONB = 0x00; //set maximum slew rate
    INLVLB = 0x00; //set the port to TTL levels
    IOCBP = 0x00; //disable rising edge interrupts
    IOCBN = 0x00; //disable falling edge interrupts
}

void Setup_ConfigurePortC(void){
    PORTC = 0x00; //clear port C
    LATC = 0X00; 
    TRISC = 0b00000000; //PortC as outputs
    ANSELC = 0x00; //portC as digital I/O
    WPUC = 0x00; //disable all pull-ups
    ODCONC = 0x00; //disable open drain
    SLRCONC = 0x00; //set maximum slew rate
    INLVLC = 0x00; //set the port to TTL levels
    IOCCP = 0x00; //disable rising edge interrupts
    IOCCN = 0x00; //disable falling edge interrupts
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