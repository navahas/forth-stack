: assert ( flag -- )
    0= ABORT" assertion failed"
;

: add-two
    \ 2 + DUP .
    DUP . ." + 2 = " 2 + .
;

: print-string
    ." this is a string of chars!" cr
;

\ : init-msg
\     ." definitions ready! -> FORTH REPL START!"
\     cr cr cr
\ ;

: main
    10 add-two .s cr
    .s cr
    10 20 .s + .s
    30 = assert cr
    print-string
;

main
bye
