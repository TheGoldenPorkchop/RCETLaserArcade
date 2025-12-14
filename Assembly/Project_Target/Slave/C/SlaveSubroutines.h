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
#ifndef BLASTER_SUBROUTINES
#define	BLASTER_SUBROUTINES

#include <xc.h> // include processor files - each processor file is guarded.  

//Function Prototypes
void ConfigurePlayerLED(unsigned char Red, unsigned char Green, unsigned char Blue);
unsigned char LoadFromEEPROM(unsigned char address);
void SaveToEEPROM(unsigned char address, unsigned char data);
void SingleFireBlaster(unsigned char PlayerNum);
void FireBlaster(unsigned char PlayerNum);

#endif	/* Blaster_SETUP */