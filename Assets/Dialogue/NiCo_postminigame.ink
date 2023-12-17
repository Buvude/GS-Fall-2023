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

Hm! Guess I'm pretty good at this, huh? #speaker:Graciana #mood:happy #ecg: 
(I wonder if I could salvage some of this junk for NiCo...?)

-> EndConvo
==pass2==
//trash toss 2
~affectionN=affectionN+3

Hm! I'm gettin' better at this! #speaker:Graciana #mood:happy #ecg: 
(Does Tundra take care of trash also, maybe?)

->EndConvo
==pass3==
//burger stack 3
~affectionN=affectionN+4

Phew! I'm nailing this, huh? #speaker:Graciana #mood:happy #ecg: 
(If NiCo could process this burger, I'm sure they'd love it!)

->EndConvo
==fail1==
~affectionN=affectionN-4

Yikes... Guess I still got a ways to go, huh? #speaker:Graciana #mood:sad #ecg: 
(NiCo's a service robot, right? maybe they'd be better at this...)

->EndConvo
==fail2==
~affectionN=affectionN-3

I still keep missing... #speaker:Graciana #mood:sad #ecg: 
(NiCo would definitely make a snide joke about me...)

->EndConvo
==fail3==
~affectionN=affectionN-2

Yeesh, I really messed that one up, huh... #speaker:Graciana #mood:sad #ecg: 
(NiCo wouldn't even dare to touch this, probably...)

->EndConvo
==chaos==
~chaosN=chaosN+4

Huh... What... What did I make...? #speaker:Graciana #mood:think #ecg: 
(I wonder what would happen if NiCo processed a burger like this...?)

->EndConvo
===EndConvo===
~convo_numberN+=1
// ~GoToAppartment()
~StartO_Ryan()
->DONE