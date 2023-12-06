INCLUDE globals.ink

==pass1==
//trash toss 1
~affectionN=affectionN+2

Hey, nice goin'! #speaker:CeCe #mood:happy

Hm! #speaker:Graciana #mood:happy
Guess I'm pretty good at this, huh?

    -> DONE
==pass2==
//trash toss 2
~affectionN=affectionN+3

Hey, good job! #speaker:CeCe #mood:happy

Hm! #speaker:Graciana #mood:happy
I'm gettin' better at this!

    -> DONE
==pass3==
//burger stack 3
~affectionN=affectionN+4

Phew! I'm nailing this, huh? #speaker:Graciana #mood:happy

Ay, I see ya are! #speaker:Chef Swatts #mood:happy
Keep it up, Gracie!
    -> DONE
==fail1==
~affectionN=affectionN-1

Yikes... #speaker:CeCe #mood:sad

S-sorry... #speaker:Graciana #mood:happy
I got a ways to go I guess, huh?

    -> DONE
==fail2==
~affectionN=affectionN-3

Yikes... #speaker:CeCe #mood:sad

S-sorry... #speaker:Graciana #mood:happy
Still not getting it...

    -> DONE
==fail3==
~affectionN=affectionN-3
Yeesh, I really messed that one up, huh... #speaker:Graciana #mood:sad

Ay... Ya kinda did, ya... #speaker:Chef Swatts #mood:sad

    -> DONE
==chaos==
~chaosN=chaosN+2
... #speaker:Graciana #mood:neutral
Huh... What... What did I make...? #speaker:Graciana #mood:think

Ay... I ain't too sure, honestly... #speaker:Chef Swatts #mood:neutral

    -> DONE