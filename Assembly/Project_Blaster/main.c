/*
   Filename:        main.c                                                          
   Date:            November 18, 2025                                                    
   File Version:    1                                                               
   Author:          Andrew Keller                                                       
   Company:         Idaho State University					    
   Description:     Laser Arcade Blaster main source code
*/

// PIC16LF1788 Configuration Bit Settings
// 'C' source line config statements
// CONFIG1
#pragma config FOSC = INTOSC    // Oscillator Selection (INTOSC oscillator: I/O function on CLKIN pin)
#pragma config WDTE = OFF       // Watchdog Timer Enable (WDT disabled)
#pragma config PWRTE = OFF      // Power-up Timer Enable (PWRT disabled)
#pragma config MCLRE = ON       // MCLR Pin Function Select (MCLR/VPP pin function is MCLR)
#pragma config CP = OFF         // Flash Program Memory Code Protection (Program memory code protection is disabled)
#pragma config CPD = OFF        // Data Memory Code Protection (Data memory code protection is disabled)
#pragma config BOREN = OFF      // Brown-out Reset Enable (Brown-out Reset disabled)
#pragma config CLKOUTEN = OFF   // Clock Out Enable (CLKOUT function is disabled. I/O or oscillator function on the CLKOUT pin)
#pragma config IESO = OFF       // Internal/External Switchover (Internal/External Switchover mode is disabled)
#pragma config FCMEN = OFF      // Fail-Safe Clock Monitor Enable (Fail-Safe Clock Monitor is disabled)
// CONFIG2
#pragma config WRT = OFF        // Flash Memory Self-Write Protection (Write protection off)
#pragma config PLLEN = OFF       // PLL Enable (4x PLL enabled)
#pragma config STVREN = OFF     // Stack Overflow/Underflow Reset Enable (Stack Overflow or Underflow will not cause a Reset)
#pragma config BORV = LO        // Brown-out Reset Voltage Selection (Brown-out Reset Voltage (Vbor), low trip point selected.)
#pragma config LPBOR = OFF      // Low Power Brown-Out Reset Enable Bit (Low power brown-out is disabled)
#pragma config LVP = OFF        // Low-Voltage Programming Enable (High-voltage on MCLR/VPP must be used for programming)

//Include Statements
#include <xc.h>
#include "BlasterSetup.h"
#include "BlasterSubroutines.h"

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

//define PORTB pin names
#define TriggerButton PORTBbits.RB1
#define SingleButton PORTBbits.RB2
#define BurstButton PORTBbits.RB3
#define AutoButton PORTBbits.RB4
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

//define EEPROM addresses
#define EEPROMPlayerNumber 0x00
#define EEPROMPlayerRed 0x01
#define EEPROMPlayerGreen 0x02
#define EEPROMPlayerBlue 0x03

//General Register Declarations
volatile unsigned char PlayerNumber __at(RAMPlayerNumber);
volatile unsigned char PlayerRed __at(RAMPlayerRed);
volatile unsigned char PlayerGreen __at(RAMPlayerGreen);
volatile unsigned char PlayerBlue __at(RAMPlayerBlue);

void __interrupt() ISR(void){
    
}

void main(void){
    //Setup the Blaster PIC
    Setup_ConfigureOscillator();
    Setup_ConfigureOptions();
    Setup_ConfigurePinFunctions();
    Setup_ConfigurePortA();
    Setup_ConfigurePortB();
    Setup_ConfigurePortC();
    PlayerNumber = LoadFromEEPROM(EEPROMPlayerNumber);
    PlayerRed = LoadFromEEPROM(EEPROMPlayerRed);
    PlayerGreen = LoadFromEEPROM(EEPROMPlayerGreen);
    PlayerBlue = LoadFromEEPROM (EEPROMPlayerBlue);
    ConfigurePlayerLED(PlayerRed, PlayerGreen, PlayerBlue);
    
    while(1==1){
        
    }
    
    return;
}
