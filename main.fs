: assert-and-rm ( flag -- )
    0= ABORT" assertion failed"
;

: assert
    0= .s ABORT" assertion failed"
;

: add-two
    \ 2 + DUP .
    DUP . ." + 2 = " 2 + .
;

: print-string
    ." this is a string of chars!" cr
;

: fill-stack
    1 2 3 4
;

: stack-ops-a
    fill-stack
    ." STACK OPS A" cr
    ." ———————————————————————————————————————" cr
    dup \ duplicate last -> .s <5> 1 2 3 4 4  ok
    drop \ remove top item from stack (silently): .s -> <4> 1 2 3 4  ok
    nip \ remove the last - 1 item from stack: .s -> <3> 1 2 4 ok
    drop \ .s -> <2> 1 2  ok
    . ." drop + print" cr \ drop and print element : . -> 2  ok
    ." dup | drop | nip | drop -> executed"
    1 = assert-and-rm cr
    ." stack restarted -> " .s cr
    ." ———————————————————————————————————————" cr
    cr
;

: stack-ops-b
    fill-stack fill-stack
    ." STACK OPS B" cr
    ." ———————————————————————————————————————" cr
    ." swap x2 | " swap swap .s cr \ swap last 2 numbers
    ." rot     | " rot .s cr \ rotate 3 last stack numbers
    ." rot     | " rot .s cr
    ." rot     | " rot .s cr
    ." over    | " over .s cr \ duplicate (last - 1)
    ." over    | " over .s cr \ duplicate (last - 1)
    ." nip     | " nip .s cr
    ." nip     | " nip .s cr
    ." nip     | " nip .s cr
    ." nip     | " nip .s cr
    ." nip     | " nip .s cr
    ." ———————————————————————————————————————" cr
    cr
;

: init-msg
    ." definitions ready! -> FORTH REPL START!"
    cr cr cr
;

: main
    10 add-two .s cr
    .s cr
    10 20 .s + .s
    30 = assert cr
    print-string
;

\ main
\ init-msg
stack-ops-a
stack-ops-b
bye
