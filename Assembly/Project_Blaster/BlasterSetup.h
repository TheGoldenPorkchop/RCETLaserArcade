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

//Function Prototypes
void Setup_ConfigureOscillator(void);
void Setup_ConfigureOptions(void);
void Setup_ConfigurePinFunctions(void);
void Setup_ConfigurePortA(void);
void Setup_ConfigurePortB(void);
void Setup_ConfigurePortC(void);
void Setup_ConfigureLasers(void);
void Setup_ConfigureAudio(void);
void Setup_ConfigureInterrupts(void);

#endif	/* Blaster_SETUP */

