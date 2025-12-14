;************************************************************************************
;										    *
;   Filename:	    SLAVE_SUBROUTINES.inc					    *
;   Date:	    December 13, 2025						    *
;   File Version:   3								    *
;   Author:	    Andrew Keller and Rudy Earnest		                    *
;   Company:	    Idaho State University					    *
;   Description:    Contains all subroutines needed for the Laser Shooting Game     *
;		    target slave. Subroutines include I2C communications, recording *
;		    player hits, and enabling/disabling the target. The I2C	    *
;		    communications includes the ability to both receive data from   *
;		    the master as well as the ability to respond to read requests   *
;		    from the master. When a hit is detected, the LED is flashed.    *
;										    *
;************************************************************************************

;************************************************************************************
;										    *
;   Revision History:								    *
;										    *
;   1:	Initialize file, get everything working the way that I thought it should    *
;	work.									    *
;										    *
;   2:	  I2C communications for enabling/disabling the target as well as reporting *
;          any player hits to the target when the target is enabled.		    *
;                                                                                   *
;   3:  Update to V2 of the slave                                                   *
;										    *
;************************************************************************************		
		
		#include "SLAVE.inc"      		; processor specific variable definitions
		#INCLUDE <SLAVE_SETUP.inc>		; Custom setup file for the PIC16F883 micro-controller
		#INCLUDE <SLAVE_SUBROUTINES.inc>	; File containing all used subroutines
		LIST      p=16f1788		  	; list directive to define processor
		errorlevel -302,-207,-305,-206,-203	; suppress "not in bank 0" message,  Found label after column 1,
							; Using default destination of 1 (file),  Found call to macro in column 1

		; CONFIG1
; __config 0xC9A4
 __CONFIG _CONFIG1, _FOSC_INTOSC & _WDTE_OFF & _PWRTE_OFF & _MCLRE_OFF & _CP_OFF & _CPD_OFF & _BOREN_OFF & _CLKOUTEN_ON & _IESO_OFF & _FCMEN_OFF
; CONFIG2
; __config 0xDFFF
 __CONFIG _CONFIG2, _WRT_OFF & _PLLEN_OFF & _STVREN_ON & _BORV_LO & _LPBOR_OFF & _LVP_OFF


		
;******************************************		
;Interrupt Vectors
;******************************************
		ORG	    H'000'			;BEGINNING OF CODE
		GOTO	    SETUP			;
		ORG	    H'004'			;INTERRUPT LOCATION
		GOTO	    INTERRUPT			;INTERRUPT OCCURRED, RUN THROUGH ISR

;******************************************
;SETUP ROUTINE
;******************************************
SETUP
		CALL	    INITIALIZE			;CALL SETUP INCLUDE FILE TO INITIALIZE PIC
		GOTO	    MAIN			;START MAIN CODE
		
;******************************************
;INTERRUPT SERVICE ROUTINE
;******************************************
INTERRUPT
		BANKSEL	    PIR1
		BTFSC	    PIR1, 5
		CALL	    UART_RX
		BANKSEL	    PIR1
		BTFSC	    PIR1,3			;CHECK SSPIF FLAG TO SEE IF DATA WAS RECIEVED FROM MASTER
		CALL	    RECEIVE			;CALL THE RECEIVE SUBROUTINE IF DATA WAS RECEIVED
	GOBACK
		BANKSEL	    PIR1			;NOTE: GOBACK ONLY USED IN I2C INTERRUPTS. IF USED FOR IOCBF, MISSES I2C REQUESTS AND MASTER CRASHES
		BCF	    PIR1,3			;CLEAR SSP1IF
		RETFIE					;RETURN TO MAIN, RE-ENABLE GIE
;Main Code
;******************************************
		
MAIN	
		GOTO	    MAIN			
END
		
;******************************************		
;END PROGRAM DIRECTIVE
;******************************************