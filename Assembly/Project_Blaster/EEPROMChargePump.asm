#include <xc.inc> 
    
;These two lines are used to reference the CHARGE_EEPROM subroutine asm in C
psect   eepromchargefunc,local,class=CODE,delta=2 ; PIC10/12/16
global _CHARGE_EEPROM ; extern of SENDLED function goes in C

;Send all bytes of data for as many connected LEDs as in LEDNUMBER
_CHARGE_EEPROM:
    BCF INTCON, 7 ;DISABLE INTERRUPTS
    BANKSEL EECON2
    MOVLW 0x55 ;PRIME THE CHARGE PUMP
    MOVWF EECON2
    MOVLW 0xAA
    MOVWF EECON2
    BSF EECON1, 1 ;SET WR BIT TO BEGIN WRITE
    BSF INTCON, 7 ;ENABLE INTERRUPTS
    RETURN