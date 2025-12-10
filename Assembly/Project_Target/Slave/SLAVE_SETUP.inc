;************************************************************************************
;										    *
;   Filename:	    SLAVE_SETUP.inc						    *
;   Date:	    April 23, 2025						    *
;   File Version:   2								    *
;   Author:	    Alex Wheelock and Andrew Keller				    *
;   Company:	    Idaho State University					    *
;   Description:    Firmware for setting up a PIC16F1788 for the target slave of    *
;		    the Laser Shooting Game project.				    *
;										    *
;************************************************************************************

;************************************************************************************
;										    *
;   Revision History:								    *
;										    *
;   1:	Iniitialize file, setup how I think it should be setup for the project.	    *
;										    *
;   2:	I2C communications for enabling/disabling the target as well as reporting   *
;       any player hits to the target when the target is enabled.		    *
;										    *
;************************************************************************************
		
;===============================================================================================================================*
;							   PORTA BITMAP								*
;===============================================================================================================================*		
;		|		|		|		|		|		|		|		*
;	7	|	6	|	5	|	4	|	3	|	2	|	1	|	0	*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*	
;DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	*
;INPUT		|INPUT		|INPUT		|INPUT		|INPUT		|INPUT		|INPUT		|INPUT		*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*		
;I2C Address	|I2C Address	|I2C Address	|I2C Address	|I2C Address	|I2C Address	|I2C Address	|I2C Address	*
;Switch		|Switch		|Switch		|Switch		|Switch		|Switch		|Switch		|Switch		*
;		|		|		|		|		|		|		|(Ignored in	*
;		|		|		|		|		|		|		|7-bit address)	*		
;-------------------------------------------------------------------------------------------------------------------------------*
		
;===============================================================================================================================*
;							   PORTB BITMAP								*
;===============================================================================================================================*		
;		|		|		|		|		|		|		|		*
;	7	|	6	|	5	|	4	|	3	|	2	|	1	|	0	*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*	
;DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	*
;INPUT		|INPUT		|INPUT		|OUTPUT		|OUTPUT		|OUTPUT		|INPUT		|INPUT		*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*		
;UNUSED		|UNUSED		|UNUSED		|RGB LEDS BLUE	|RGB LEDS RED	|RGB LEDS GREEN	|56kHz IR Input	|38kHz IR Input	*
;		|		|		|		|		|		|		|		*
;		|		|		|		|		|		|		|		*
;		|		|		|		|		|		|		|		*		
;-------------------------------------------------------------------------------------------------------------------------------*
		
;===============================================================================================================================*
;							   PORTC BITMAP								*
;===============================================================================================================================*		
;		|		|		|		|		|		|		|		*
;	7	|	6	|	5	|	4	|	3	|	2	|	1	|	0	*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*	
;DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	|DIGITAL	*
;OUTPUT		|OUTPUT		|OUTPUT		|OUTPUT		|OUTPUT		|OUTPUT		|OUTPUT		|OUTPUT		*
;---------------|---------------|---------------|---------------|---------------|---------------|---------------|---------------*		
;UNUSED		|UNUSED		|UNUSED		|I2C SDA	|I2C SCL	|UNUSED		|UNUSED		|UNUSED		*
;		|		|		|		|		|		|		|		*
;		|		|		|		|		|		|		|		*
;		|		|		|		|		|		|		|		*		
;-------------------------------------------------------------------------------------------------------------------------------*		
		
		
  EEPROM_ADDR   EQU 0x20
  EEPROM_DATA   EQU 0x21
  EEPROM_SAVE   EQU 0x22
  ;Status Registers
  TARGET_STATUS EQU 0x23
  ACTIVE        EQU 0x24
  ;I2C Variables
  RECEIVED_DATA EQU 0x25
  I2C_Color_Count   EQU 0x37
   ; For the flags bit 0 means that I2C color protocol is enabled
   ; Bit 1 means that Player 1's color is being changed
   ; Bit 2 means that Player 2's color is being changed
   ; Bit 3 means that Player 3's color is being changed
   ; Bit 4 means that Player 4's color is being changed
  I2C_ColorFlag EQU 0x38
  ;Player Variables
  P1_R          EQU 0x26
  P2_R          EQU 0x27
  P3_R          EQU 0x28
  P4_R          EQU 0x29
  P1_G          EQU 0x2A
  P2_G          EQU 0x2B
  P3_G          EQU 0x2C
  P4_G          EQU 0x2D
  P1_B          EQU 0x2E
  P2_B          EQU 0x2F
  P3_B          EQU 0x30
  P4_B          EQU 0x31
  ;LED Variables
  _SENDLEDRED   EQU 0x32
  _SENDLEDBLUE  EQU 0x33
  _SENDLEDGREEN EQU 0x34
  _LEDNUMBER    EQU 0x35
  _LEDCOUNTER   EQU 0x36
   ;EUSART VARIABLES
   EU_RX	EQU 0X39
   EU_TX	EQU 0X3A
   ;BIT 0 USED FOR THE W (0X57) COMMAND
   ;BIT 1 USED FOR THE R (0X52) COMMAND
   ;BIT 2 USED FOR THE C (0X43) COMMAND
   ;BIT 3 USED FOR THE BLASTER FIRE COMMAND
   ;BIT 4 USED FOR THE P (0X50) COMMAND
   ;BIT 5 USED FOR THE L (0X4C) COMMAND
   ;BIT 7 SAYS DOLLAR WAS RECEIVED
   EU_FLAG	EQU 0X3B
   EU_COUNTER	EQU 0X3C
   EU_TXFLAG	EQU 0X3D
   PLAYER_HIT	EQU 0X4B
   ;MOTOR VARIABLES
   CAL_POS	EQU 0X3E
   S1E_PH	EQU 0X3F
   S1E_PL	EQU 0X40
   S1D_PH	EQU 0X41
   S1D_PL	EQU 0X42
   S2E_PH	EQU 0X43
   S2E_PL	EQU 0X44
   S2D_PH	EQU 0X45
   S2D_PL	EQU 0X46
   S3E_PH	EQU 0X47
   S3E_PL	EQU 0X48
   S3D_PH	EQU 0X49
   S3D_PL	EQU 0X4A
		
INITIALIZE_CODE	CODE		
INITIALIZE	
	
;*** INTOSC SETUP *******
	
		BANKSEL	    OSCCON
		MOVLW	    0xF8			;ENABLE INTOSC, SET TO 16MHz
		MOVWF	    OSCCON
		BANKSEL	    CLKRCON
		CLRF	    CLKRCON			;DISABLE CLOCK REFERENCE
		
;*** SET OPTION_REG: ****
		
		BANKSEL	    OPTION_REG
		MOVLW	    0x48
		MOVWF	    OPTION_REG
		
;*** SET INTCON REG: ****
		
		BANKSEL INTCON
		BSF	    INTCON, IOCIE		;ENABLE IOC INTERUPT
		BCF	    INTCON, INTE		;DISABLE INT EXTERNAL INTERUPT
		BSF	    INTCON, PEIE		;ENABLE PERIPHERAL INTERUPTS
		BSF	    INTCON, GIE			;ENABLE ALL UNMASKED INTERUPTS
		
;*** SET PIE1-4 REG: *****
		
		BANKSEL	    PIE1
		MOVLW	    0x28
		MOVWF	    PIE1			;DISABLE ALL PIE1 INTERUPTS, EXCEPT SSP1F AND RCIE
		BANKSEL	    PIE2
		CLRF	    PIE2			;DISABLE ALL PIE2 INTERUPTS
		BANKSEL	    PIE3
		CLRF	    PIE3			;DISABLE ALL PIE3 INTERUPTS
		BANKSEL	    PIE4
		CLRF	    PIE4			;DISABLE ALL PIE4 INTERUPTS
		
;*** CLEAR INTERUPT FLAGS ***
		
		BANKSEL	    PIR1
		CLRF	    PIR1			;CLEAR ALL PIR1 INTERUPT FLAGS
		BANKSEL	    PIR2
		CLRF	    PIR2			;CLEAR ALL PIR2 INTERUPT FLAGS
		BANKSEL	    PIR3
		CLRF	    PIR3			;CLEAR ALL PIR3 INTERUPT FLAGS
		BANKSEL	    PIR4
		CLRF	    PIR4			;CLEAR ALL PIR4 INTERUPT FLAGS			
		
;*** ALTERNATE PIN FUNCTION *****
		
		BANKSEL	    APFCON1
		MOVLW	    0x06
		MOVWF	    APFCON1			;SELECTS PORT MAPPING
		CLRF	    APFCON2			;SEE DATASHEET (pg 132-133) FOR MAPPING WITH BOTH CLEARED
		
;*** TMR1 SETUP ****
		
		BANKSEL	    T1CON
		MOVLW	    0xA8			;ENABLE & SELECT TMR1 LP OSCILLATOR, SET PRESCALE TO 1:4, DISABLE TMR1 AT THIS POINT
		BANKSEL	    T1GCON
		CLRF	    T1GCON			;DISABLE TMR1 GATE
 
;*** PORT A SETUP **** PORT A SET AS LOGIC INPUT (I2C ADDRESS)

		BANKSEL	    PORTA
		MOVLW	    0x00
		MOVWF	    PORTA			;CLEAR PORTA
		BANKSEL	    LATA
		MOVLW	    0x00			;CLEAR LATA
		MOVWF	    LATA
		BANKSEL	    TRISA
		MOVLW	    0xF0  
		MOVWF	    TRISA			;SET PORTA ALL AS INPUTS
		BANKSEL	    ODCONA
		CLRF	    ODCONA			;DISABLE PORTA OPEN-DRAIN		
		BANKSEL	    ANSELA			
		CLRF	    ANSELA			;SET PORTA ALL AS DIGITAL INPUT
		BANKSEL	    SLRCONA
		CLRF	    SLRCONA			;SET THE SLEW RATE FOR PORT A TO MAXIMUM
		BANKSEL	    IOCAP
		MOVLW	    0x00
		MOVWF	    IOCAP
		BANKSEL	    IOCAN
		CLRF	    IOCAN
		
;*** PORT B SETUP **** PORT B USED AS LOGIC INPUT AND OUTPUT
		
		BANKSEL	    PORTB
		MOVLW	    0x00
		MOVWF	    PORTB			;CLEAR PORTB	
		BANKSEL	    LATB
		CLRF	    LATB			;CLEAR LATB
		BANKSEL	    TRISB
		MOVLW	    0xFF				
		MOVWF	    TRISB			;SET PORTB ACCORDING TO BITMAP
		BANKSEL	    ODCONB
		CLRF	    ODCONB			;DISABLE PORTB OPEN-DRAIN
		BANKSEL	    ANSELB
		CLRF	    ANSELB			;MAKE PORTB DIGITAL INPUTS
		BANKSEL	    SLRCONB
		CLRF	    SLRCONB			;SET THE SLEW RATE FOR PORT B TO MAXIMUM
		BANKSEL	    IOCBP
		MOVLW	    0x00			;DISABLE PORTB IOC FOR POSITIVE EDGES
		MOVWF	    IOCBP
		BANKSEL	    IOCBN
		MOVLW	    0x00			;ENABLE PORTB IOC FOR NEGATIVE EDGES ON RB0 AND RB1
		MOVWF	    IOCBN
		BANKSEL	    INLVLB
		CLRF	    INLVLB			;SET PORTB INPUT THRESHOLD TO TTL (IGNORED NOISE BETTER FOR TRIGGER INPUT)	    	    
		
;*** PORT C SETUP **** 
		
		BANKSEL	    PORTC
		CLRF	    PORTC			;CLEAR PORTC
		BANKSEL	    LATC
		CLRF	    LATC			;CLEAR LATC
		BANKSEL	    TRISC
		MOVLW	    0x9A				
		MOVWF	    TRISC			;SET PORTC ALL AS INPUTS
		BANKSEL	    ODCONC
		CLRF	    ODCONC			;DISABLE PORTC OPEN-DRAIN
		BANKSEL	    ANSELC
		CLRF	    ANSELC			;MAKE PORTC ALL DIGITAL I/O
		BANKSEL	    SLRCONC
		CLRF	    SLRCONC			;SET THE SLEW RATE FOR PORT C TO MAXIMUM
		BANKSEL	    IOCCP
		MOVLW	    0x00			;DISALBE PORTC IOC FOR POSITIVE EDGES
		MOVWF	    IOCCP
		BANKSEL	    IOCCN
		MOVLW	    0x00			;DISABLE PORTC IOC FOR NEGATIVE EDGES
		MOVWF	    IOCCN
		BANKSEL	    INLVLC
		CLRF	    INLVLC			;SET PORTC INPUT THRESHOLD TO TTL (IGNORED NOISE BETTER FOR TRIGGER INPUT)
		
;*** I2C SETUP ****
		BANKSEL	    SSPADD		
		MOVLW	    0x02
		MOVWF	    SSPADD			;SET I2C ADDRESS
		BANKSEL	    SSPCON
		MOVLW	    0x16			;SET TO I2C 7-BIT ADDRESS SLAVE MODE
		MOVWF	    SSPCON			;
		BSF	    SSPCON,5			;ENABLE SERIAL PORT FOR I2C
		BANKSEL	    SSPCON2
		MOVLW	    0x80
		MOVWF	    SSPCON2
		BANKSEL	    SSPCON3
		CLRF	    SSPCON3
		BANKSEL	    SSPSTAT
		MOVLW	    0xC0
		MOVWF	    SSPSTAT
		
		
;*** UART SETUP ***
		BANKSEL	    SP1BRGH
		MOVLW	    0x03			;SET UART BAUD RATE TO 9600 W/ 16MHz OSCILLATOR
		MOVWF	    SP1BRGH
		BANKSEL	    SP1BRGL
		MOVLW	    0x40
		MOVWF	    SP1BRGL
		BANKSEL	    BAUD1CON
		MOVLW	    0x08			;00001000 CONFIGURE FOR 16-BIT BAUD RATE GENERATOR
		MOVWF	    BAUD1CON
		BANKSEL	    RC1STA
		MOVLW	    0x90			;10010000 ENABLE UART PORT, ENABLE RECEIVER
		MOVWF	    RC1STA
		BANKSEL	    TX1STA
		MOVLW	    0x20			;00100110 ENABLE TRANSMITTER, HIGH SPEED MODE, ASYNCHRONOUS
		MOVWF	    TX1STA
  
		
;*** BOOT CODE ****
		
		BANKSEL	    PORTA
		CLRF	    TARGET_STATUS		;CLEAR TARGET_STATUS TO PREVENT INACCURATE SCORE
		CLRF	    ACTIVE			;ENSURE TARGET STARTS DISABLED	    
		BANKSEL	    INTCON  
		BCF	    INTCON,0
		BANKSEL	    IOCAF
		CLRF	    IOCAF
		BCF	    INTCON,IOCIF		;CLEAR IOCIF
		BANKSEL	    PORTA
		
		
  ;*** PSMC SETUP ***
		BANKSEL	    PSMC1OEN
		MOVLW	    0X01
		MOVWF	    PSMC1OEN
		BANKSEL	    PSMC2OEN
		MOVWF	    PSMC2OEN
		BANKSEL	    PSMC3OEN
		MOVWF	    PSMC3OEN
		BANKSEL	    TRISC
		BCF	    TRISC,0
		BCF	    TRISC,5
		BCF	    TRISC,6

		BANKSEL	    PSMC1PRS
		BSF	    PSMC1PRS, P1PRST
		BANKSEL	    PSMC2PRS
		BSF	    PSMC2PRS,P2PRST
		BANKSEL	    PSMC3PRS
		BSF	    PSMC3PRS,P3PRST

		BANKSEL	    PSMC1PHS
		BSF	    PSMC1PHS,P1PHST
		BANKSEL	    PSMC2PHS
		BSF	    PSMC2PHS,P2PHST
		BANKSEL	    PSMC3PHS
		BSF	    PSMC3PHS,P3PHST

		BANKSEL	    PSMC1DCS
		BSF	    PSMC1DCS,P1DCST
		BANKSEL	    PSMC2DCS
		BSF	    PSMC2DCS,P2DCST
		BANKSEL	    PSMC3DCS
		BSF	    PSMC3DCS,P3DCST

		BANKSEL	    PSMC1CLK
		MOVLW	    0X32
		MOVWF	    PSMC1CLK
		BANKSEL	    PSMC2CLK
		MOVWF	    PSMC2CLK
		BANKSEL	    PSMC3CLK
		MOVWF	    PSMC3CLK

		BANKSEL	    PSMC1PRL
		MOVLW	    0X20
		MOVWF	    PSMC1PRL
		BANKSEL	    PSMC2PRL
		MOVWF	    PSMC2PRL
		BANKSEL	    PSMC3PRL
		MOVWF	    PSMC3PRL
		MOVLW	    0X4E
		BANKSEL	    PSMC1PRH
		MOVWF	    PSMC1PRH
		BANKSEL	    PSMC2PRH
		MOVWF	    PSMC2PRH
		BANKSEL	    PSMC3PRH
		MOVWF	    PSMC3PRH

		BANKSEL	    PSMC1DCL
		MOVLW	    0X10
		MOVWF	    PSMC1DCL
		BANKSEL	    PSMC2DCL
		MOVWF	    PSMC2DCL
		BANKSEL	    PSMC3DCL
		MOVWF	    PSMC3DCL
		MOVLW	    0X27
		BANKSEL	    PSMC1DCH
		MOVWF	    PSMC1DCH
		BANKSEL	    PSMC2DCH
		MOVWF	    PSMC2DCH
		BANKSEL	    PSMC3DCH
		MOVWF	    PSMC3DCH

		MOVLW	    0X00
		BANKSEL	    PSMC1PHH
		MOVWF	    PSMC1PHH
		BANKSEL	    PSMC2PHH
		MOVWF	    PSMC2PHH
		BANKSEL	    PSMC3PHH
		MOVWF	    PSMC3PHH
		BANKSEL	    PSMC1PHL
		MOVWF	    PSMC1PHL
		BANKSEL	    PSMC2PHL
		MOVWF	    PSMC2PHL
		BANKSEL	    PSMC3PHL
		MOVWF	    PSMC3PHL

		BANKSEL	    PSMC1CON
		MOVLW	    0XC0
		MOVWF	    PSMC1CON
		BANKSEL	    PSMC2CON
		MOVWF	    PSMC2CON
		BANKSEL	    PSMC3CON
		MOVWF	    PSMC3CON

		BANKSEL	    PORTA
		CLRF	    EU_FLAG
		CLRF	    PLAYER_HIT
		MOVLW	    0xFF
		MOVWF	    P1_R
		CLRF	    P1_G
		CLRF	    P1_B
		MOVLW	    0xFF
		MOVWF	    P2_B
		CLRF	    P2_G
		CLRF	    P2_R

		RETURN					;RETURN TO .asm FILE