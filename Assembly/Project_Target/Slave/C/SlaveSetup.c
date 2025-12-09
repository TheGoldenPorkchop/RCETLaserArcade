/*
   Filename:        BlasterSetup.c                                                          
   Date:            November 18, 2025                                                    
   File Version:    1                                                               
   Author:          Andrew Keller                                                       
   Company:         Idaho State University					    
   Description:     Laser Arcade Blaster Setup Source Code File
*/

#include <xc.h>
#include "SlaveSetup.h"

void Setup_ConfigureOscillator(void){
    OSCCON = 0x7A; //Enable Internal osc, set to 32MHz
    CLKRCON = 0x00; //Disable Clock Reference
}

void Setup_ConfigureOptions(void){
    OPTION_REG = 0x48;
}

void Setup_ConfigurePinFunctions(void){
    APFCON1 = 0x00;
    APFCON2 = 0x00;
}

void Setup_ConfigurePortA(void){
    PORTA = 0x00; //clear port A
    LATA = 0x00; 
    TRISA = 0x00; //porta as outputs
    ANSELA = 0b00000000; //porta as digital I/O
    WPUA = 0x00; //disable all pull-ups
    ODCONA = 0x00; //disable open drain
    SLRCONA = 0x00; //set maximum slew rate
    INLVLA = 0x00; //set the port to TTL levels
    IOCAP = 0x00; //disable rising edge interrupts
    IOCAN = 0x00; //disable falling edge interrupts
    PORTA = 0x00; //disable all audio
}

void Setup_ConfigurePortB(void){
    PORTB = 0x00; //clear port B
    LATB = 0x00; 
    TRISB = 0x00; //portb as inputs, RB6 as output
    ANSELB = 0x00; //portb as digital I/O
    WPUB = 0x00; //disable all pull-ups
    ODCONB = 0x00; //disable open drain
    SLRCONB = 0x00; //set maximum slew rate
    INLVLB = 0x00; //set the port to TTL levels
    IOCBP = 0x00; //enable RB2, RB3, RB4 rising edge interrupts
    IOCBN = 0x00; //enable RB1 falling edge interrupt
}

void Setup_ConfigurePortC(void){
    PORTC = 0x00; //clear port C
    LATC = 0x00; 
    TRISC = 0x9A; //PortC as outputs
    ANSELC = 0x00; //portC as digital I/O
    WPUC = 0x00; //disable all pull-ups
    ODCONC = 0x00; //disable open drain
    SLRCONC = 0x00; //set maximum slew rate
    INLVLC = 0x00; //set the port to TTL levels
    IOCCP = 0x00; //disable rising edge interrupts
    IOCCN = 0x00; //disable falling edge interrupts
}

void Setup_ConfigureI2C(void) {
    SSP1ADD = 0x04;
    
    SSP1CON1 = 0x36;
    SSP1CON2 = 0x80;
    SSP1CON3 = 0x00;
    SSP1STAT = 0xC0;
}

void Setup_ConfigureInterrupts(void){
    INTCON = 0x40; //enable interrupts on change and peripheral interrupts
    
    //configure peripheral interrupts
    PIE1 = 0x08; //enable UART RX interrupt
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
    
}