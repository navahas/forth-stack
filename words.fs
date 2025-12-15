
: SQUARE
    DUP *
;

: LOAD-STACK
    8 1 4 6
;

: PRINT-LAST
    DUP ." Last stack item -> " . cr
;

: SQUARE-PRINT
    SQUARE PRINT-LAST
;

: SQUARE-POP
    SQUARE .
;

: DOUBLE
    DUP +
;

: MAIN
    LOAD-STACK
    SQUARE
    PRINT-LAST
    ." 8: " 8 SQUARE-PRINT
    ." 11:" 11 SQUARE-PRINT
    ." 4:" 4 SQUARE-PRINT
    3 SQUARE-POP cr
    7 SQUARE-POP cr
    9 SQUARE-POP cr
;

: MAIN-TWO
    10 .s ." | " DOUBLE . cr
    20 .s ." | " DOUBLE . cr
    55 .s ." | " DOUBLE . cr
    15 .s ." | " DOUBLE . cr
    10 .s ." | " SQUARE DOUBLE SQUARE . cr
;

\ MAIN
MAIN-TWO
\ bye
