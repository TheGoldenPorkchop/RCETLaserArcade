/*
   Filename:        BlasterSetup.h                                                          
   Date:            November 18, 2025                                                    
   File Version:    1                                                               
   Author:          Andrew Keller                                                       
   Company:         Idaho State University					    
   Description:     Laser Arcade Blaster Setup Header File
*/

// This is a guard condition so that contents of this file are not included
// more than once.  
#ifndef BLASTER_SETUP
#define	BLASTER_SETUP

#include <xc.h> // include processor files - each processor file is guarded.  

//define oscillation frequency
#define _XTAL_FREQ 8000000 //Fosc of 8MHz

//define PORTA pin names
#define AudioTRIG0 PORTAbits.RA0
#define AudioTRIG1 PORTAbits.RA1
#define AudioTRIG2 PORTAbits.RA2
#define AudioTRIG3 PORTAbits.RA3
#define AudioTRIG4 PORTAbits.RA4
#define AudioTRIG5 PORTAbits.RA5
#define AudioEnable PORTAbits.RA6
#define Solenoid PORTAbits.RA7

//define PORTB interrupt flag names
#define TriggerButtonFlag IOCBFbits.IOCBF1
#define TriggerButton PORTBbits.RB1
#define SingleButtonFlag IOCBFbits.IOCBF2
#define BurstButtonFlag IOCBFbits.IOCBF3
#define AutoButtonFlag IOCBFbits.IOCBF4
#define AudioActivity PORTBbits.RB5

//define PORTC pin names
#define ModeBlue PORTCbits.RC5
#define ModeRed PORTCbits.RC3
#define ModeGreen PORTCbits.RC4

//define RAM addresses
#define RAMPlayerNumber 0x20
#define RAMPlayerRed 0x21
#define RAMPlayerGreen 0x22
#define RAMPlayerBlue 0x23
#define RAMMode 0x24

//define EEPROM addresses
#define EEPROMPlayerNumber 0x00
#define EEPROMPlayerRed 0x01
#define EEPROMPlayerGreen 0x02
#define EEPROMPlayerBlue 0x03

//Function Prototypes
void Setup_ConfigureOscillator(void);
void Setup_ConfigureOptions(void);
void Setup_ConfigurePinFunctions(void);
void Setup_ConfigurePortA(void);
void Setup_ConfigurePortB(void);
void Setup_ConfigurePortC(void);
void Setup_ConfigureI2C(void);
void Setup_ConfigureAudio(unsigned char PlayerNum);
void Setup_ConfigureInterrupts(void);

#endif	/* Blaster_SETUP */