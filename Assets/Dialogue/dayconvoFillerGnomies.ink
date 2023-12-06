INCLUDE globals.ink
EXTERNAL GoToAppartment()
Hello! We are the Gnomies! #speaker:Gnomies #mood:angry

Quiet you!

Can I get you to anything? #speaker:Graciana #mood:think

I request that you present to me a singular slice of lingonberry sweet pie, #speaker:Gnomies #mood:neutral

Since I presume you heathens here don't have any joy essence here...

*[Right away.]
    ~affectionG+=1
    ->EndConvo
*[I don't like your attitude.]
    ~affectionG-=1
    ->EndConvo
*[I'll get you both some.]
    ~chaosG+=1
    ->EndConvo


===EndConvo===
~convo_numberG+=1
~GoToAppartment()
->DONE