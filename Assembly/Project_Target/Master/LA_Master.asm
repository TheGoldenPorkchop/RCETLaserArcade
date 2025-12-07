;************************************************************************************
;										    *
;   Filename:	    LA_Master.asm						    *
;   Date:	    April 22, 2025						    *
;   File Version:   2								    *
;   Author:	    Alex Wheelock and Andrew Keller				    *
;   Company:	    Idaho State University					    *
;   Description:    Assembly file for the master controller for a laser shooting    *
;		    arcade. Includes the ability to communicate with a computer	    *
;		    via UART. Can control up to 8 targets simultaneously with	    *
;		    various target slots. Each slot can be changed to a different   *
;		    I2C address using UART commands.				    *
;										    *
;************************************************************************************

;************************************************************************************
;										    *
;   Revision History:								    *
;										    *
;   1:	  Got everything for the gun working the way that I think it should with    *
;	  base features.							    *
;										    *
;   2:	  Added UART functionality, I2C capability to control up to 8 targets	    *
;										    *	
;************************************************************************************		
		
;		#include "MASTER.inc"      		; processor specific variable definitions
		//processor specific variable definitions
		#include "MASTER.inc"
		//Custom setup file for the PIC16F883 micro-controller
		#include "MASTER_SETUP.inc"
		//File containing all used subroutines
		#include "MASTER_SUBROUTINES.inc"

		LIST      p=16f1788		  	; list directive to define processor
		;errorlevel -302,-207,-305,-206,-203	; suppress "not in bank 0" message,  Found label after column 1,
							; Using default destination of 1 (file),  Found call to macro in column 1

		; CONFIG1
; __config 0xC9A4
; __CONFIG _CONFIG1, _FOSC_INTOSC & _WDTE_OFF & _PWRTE_OFF & _MCLRE_ON & _CP_OFF & _CPD_OFF & _BOREN_OFF & _CLKOUTEN_OFF & _IESO_OFF & _FCMEN_OFF
; CONFIG2
; __config 0xDFFF
; __CONFIG _CONFIG2, _WRT_OFF & _PLLEN_OFF & _STVREN_ON & _BORV_LO & _LPBOR_OFF & _LVP_OFF
		
; PIC16F1788 Configuration Bit Settings
; Assembly source line config statements
; CONFIG1
  CONFIG  FOSC = INTOSC         ; Oscillator Selection (INTOSC oscillator: I/O function on CLKIN pin)
  CONFIG  WDTE = OFF            ; Watchdog Timer Enable (WDT disabled)
  CONFIG  PWRTE = OFF           ; Power-up Timer Enable (PWRT disabled)
  CONFIG  MCLRE = ON            ; MCLR Pin Function Select (MCLR/VPP pin function is MCLR)
  CONFIG  CP = OFF              ; Flash Program Memory Code Protection (Program memory code protection is disabled)
  CONFIG  CPD = OFF             ; Data Memory Code Protection (Data memory code protection is disabled)
  CONFIG  BOREN = OFF           ; Brown-out Reset Enable (Brown-out Reset disabled)
  CONFIG  CLKOUTEN = OFF        ; Clock Out Enable (CLKOUT function is disabled. I/O or oscillator function on the CLKOUT pin)
  CONFIG  IESO = OFF            ; Internal/External Switchover (Internal/External Switchover mode is disabled)
  CONFIG  FCMEN = OFF           ; Fail-Safe Clock Monitor Enable (Fail-Safe Clock Monitor is disabled)

; CONFIG2
  CONFIG  WRT = OFF             ; Flash Memory Self-Write Protection (Write protection off)
  CONFIG  VCAPEN = OFF          ; Voltage Regulator Capacitor Enable bit (Vcap functionality is disabled on RA6.)
  CONFIG  PLLEN = OFF           ; PLL Enable (4x PLL disabled)
  CONFIG  STVREN = ON           ; Stack Overflow/Underflow Reset Enable (Stack Overflow or Underflow will cause a Reset)
  CONFIG  BORV = LO             ; Brown-out Reset Voltage Selection (Brown-out Reset Voltage (Vbor), low trip point selected.)
  CONFIG  LPBOR = OFF           ; Low Power Brown-Out Reset Enable Bit (Low power brown-out is disabled)
  CONFIG  DEBUG = OFF           ; In-Circuit Debugger Mode (In-Circuit Debugger disabled, ICSPCLK and ICSPDAT are general purpose I/O pins)
  CONFIG  LVP = OFF             ; Low-Voltage Programming Enable (High-voltage on MCLR/VPP must be used for programming)

// config statements should precede project file includes.
#include <xc.inc>


		
;******************************************		
;Interrupt Vectors
;******************************************
PSECT resetVect,class=CODE,delta=2 ;Reset vector address -Wl,-presetVect=00h
    GOTO SETUP ;BEGINNING OF CODE
    
PSECT isrVect,class=CODE,delta=2 ;isr or something
    GOTO INTERRUPT ;INTERRUPT OCCURRED, RUN THROUGH ISR
    
PSECT code,class=CODE,delta=2 ;-Wl,-pcode=08h
    GOTO SETUP
 
		;ORG	    H'000'			;BEGINNING OF CODE
		;GOTO	    SETUP			;
		;ORG	    H'004'			;INTERRUPT LOCATION
		;GOTO	    INTERRUPT			;INTERRUPT OCCURRED, RUN THROUGH ISR

;******************************************
;SETUP ROUTINE
;******************************************
SETUP:
		CALL	    INITIALIZE			;CALL SETUP INCLUDE FILE TO INITIALIZE PIC
		GOTO	    MAIN			;START MAIN CODE
		
;******************************************
;INTERRUPT SERVICE ROUTINE
;******************************************
INTERRUPT:
		BANKSEL	    PIR1
		BTFSC	    RCIF			;IF INTERRUPTED BY UART RECEIVE, GOTO UARTRECEIVE
		GOTO	    UARTRECEIVE
		BTFSC	    TMR2IF			;IF INTERRUPTED BY TMR2, GOTO TIMEOUT
		GOTO	    TIMEOUT
		GOTO	    GOBACK			;ELSE GOBACK
	UARTRECEIVE:
		CALL	    UARTRX			;CALL THE UARTRX SUBROUTINE
		GOTO	    GOBACK
	TIMEOUT:
		CALL	    TIMEDOUT
		RETFIE
	GOBACK:
		BANKSEL	    PIR1
		CLRF	    PIR1			;CLEAR ALL PIR1 FLAGS
		RETFIE					;RETURN TO MAIN, RE-ENABLE GIE
		
;******************************************
;Main Code
;******************************************
MAIN:
		GOTO	    MAIN
;******************************************		
;END PROGRAM DIRECTIVE
;******************************************
END