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
    OSCCON = 0b01110000; //Enable Internal osc, set to 8MHz
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
    PORTA = 0b01111111; //clear port A
    LATA = 0b01111111; 
    TRISA = 0b00000000; //porta as outputs
    ANSELA = 0b00000000; //porta as digital I/O
    WPUA = 0x00; //disable all pull-ups
    ODCONA = 0x00; //disable open drain
    SLRCONA = 0x00; //set maximum slew rate
    INLVLA = 0x00; //set the port to TTL levels
    IOCAP = 0x00; //disable rising edge interrupts
    IOCAN = 0x00; //disable falling edge interrupts
    PORTA = 0b01111111; //disable all audio
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
    IOCBP = 0b00011100; //enable RB2, RB3, RB4 rising edge interrupts
    IOCBN = 0b00000010; //enable RB1 falling edge interrupt
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

void Setup_ConfigureLasers(void) {
    SPBRGH = 0x00; //UART BAUD RATE OF 2400 W/ 32MHz OSCILLATOR
    SPBRGL = 0xCF;
    BAUDCON = 0b00001000; //16-BIT BAUD RATE GENERATOR
    RCSTA = 0b10010000; //ENABLE UART PORT, ENABLE RECEIVER
    TXSTA = 0b00100000; //ENABLE TRANSMITTER, ASYNCHRONOUS
    
    PSMC1PRH = 0x00; //Set the frequency to 38kHz
    PSMC1PRL = 0x68;
    PSMC1DCH = 0x00; //set the falling edge to centered 50% DC
    PSMC1DCL = 0x34;
    PSMC1PHH = 0x00; //set the rising edge to always 0
    PSMC1PHL = 0x00;
    PSMC1CLK = 0b00010000; //Set PSMC1 clock to FOSC/2 (4MHz)
    PSMC1STR0 = 0x01; //enable PSMC output 1
    PSMC1POL = 0x00; //polarity is active high
    PSMC1OEN = 0x01; //output enabled A
    PSMC1PRS = 0x01; //only time base causes a period event
    PSMC1PHS = 0x01; //only time base causes a rising edge event
    PSMC1DCS = 0x01; //only time base causes a falling edge event
    PSMC1MDL = 0b11101000; //PSMC1 is modulated by active low signal at PSMC1IN
    PSMC1CON = 0b11000000; //enable PSMC and load changes in
}

void Setup_ConfigureInterrupts(void){
    INTCON = 0b01001000; //enable interrupts on change and peripheral interrupts
    
    //configure peripheral interrupts
    PIE1 = 0b00100000; //enable UART RX interrupt
    PIE2 = 0x00;
    PIE3 = 0x00;
    PIE4 = 0x00;
    
    //clear all peripheral flags
    PIR1 = 0x00;
    PIR2 = 0x00;
    PIR3 = 0x00;
    PIR4 = 0x00;
    
    INTCONbits.GIE = 1; //enable global interrupts
}

void Setup_ConfigureAudio(unsigned char PlayerNum){
    //setup the class D 100kHz square wave
    PSMC2PRH = 0x00; //Set the frequency to 100kHz
    PSMC2PRL = 0x4F;
    PSMC2DCH = 0x00; //set the falling edge to centered 50% DC
    PSMC2DCL = 0x27;
    PSMC2PHH = 0x00; //set the rising edge to always 0
    PSMC2PHL = 0x00;
    PSMC2CLK = 0b00000000; //Set PSMC2 clock to FOSC/1 (8MHz)
    PSMC2STR0 = 0x02; //enable PSMC output B
    PSMC2POL = 0x00; //polarity is active high
    PSMC2OEN = 0x02; //output enabled B
    PSMC2PRS = 0x01; //only time base causes a period event
    PSMC2PHS = 0x01; //only time base causes a rising edge event
    PSMC2DCS = 0x01; //only time base causes a falling edge event
    PSMC2MDL = 0x00; //PSMC1 is not modulated
    PSMC2CON = 0b11000000; //enable PSMC and load changes in
    
    //disable all audio
    AudioTRIG0 = 1;
    AudioTRIG1 = 1;
    AudioTRIG2 = 1;
    AudioTRIG3 = 1;
    AudioTRIG4 = 1;
    AudioTRIG5 = 1;
    
    AudioEnable = 1; //enable speaker
    AudioTRIG0 = 0; //play trigger 0
    while (AudioActivity == 1){} //wait for audio to start playing
    AudioTRIG0 = 1;
    while (AudioActivity == 0){} //wait for audio to finish playing
    __delay_ms(150);
    AudioEnable = 0; //disable speaker
}