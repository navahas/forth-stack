: assert ( flag -- )
    0= ABORT" assertion failed"
;

: add
    +
;

: main
    10 20 .s add .s
    30 = assert
    cr
;

main
bye
