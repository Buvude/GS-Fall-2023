INCLUDE globals.ink
->whereToGo
==whereToGo==
~QuickLoad()
{
-currentConvo=="NMG1":
{
-winState=="won":
->pass1
-winState=="lost":
->fail1
}
-currentConvo=="NMG2":
{
-winState=="won":
->pass2
-winState=="lost":
->fail2
}
-currentConvo=="NMG3":
{
-winState=="chaos":
->chaos
-winState=="won":
->pass3
-winState=="lost":
->fail3
}
}
==pass1==
//trash toss 1
~affectionN=affectionN+2

Hey, nice goin'! #speaker:CeCe #mood:happy

Hm! #speaker:Graciana #mood:happy
Guess I'm pretty good at this, huh?

-> EndConvo
==pass2==
//trash toss 2
~affectionN=affectionN+3

Hey, good job! #speaker:CeCe #mood:happy

Hm! #speaker:Graciana #mood:happy
I'm gettin' better at this!

->EndConvo
==pass3==
//burger stack 3
~affectionN=affectionN+4

Phew! I'm nailing this, huh? #speaker:Graciana #mood:happy

Ay, I see ya are! #speaker:Chef Swatts #mood:happy
Keep it up, Gracie!
->EndConvo
==fail1==
~affectionN=affectionN-4

Yikes... #speaker:CeCe #mood:sad

S-sorry... #speaker:Graciana #mood:happy
I got a ways to go I guess, huh?

->EndConvo
==fail2==
~affectionN=affectionN-3

Yikes... #speaker:CeCe #mood:sad

S-sorry... #speaker:Graciana #mood:happy
Still not getting it...

->EndConvo
==fail3==
~affectionN=affectionN-2
Yeesh, I really messed that one up, huh... #speaker:Graciana #mood:sad

Ay... Ya kinda did, ya... #speaker:Chef Swatts #mood:sad

->EndConvo
==chaos==
~chaosN=chaosN+4
...#speaker:Chef Swatts #mood:neutral
... #speaker:Graciana #mood:neutral
Huh... What... What did I make...? #speaker:Graciana #mood:think 

Ay... I ain't too sure, honestly... #speaker:Chef Swatts #mood:neutral

->EndConvo
===EndConvo===
~convo_numberN+=1
// ~GoToAppartment()
~StartO_Ryan()
->DONE