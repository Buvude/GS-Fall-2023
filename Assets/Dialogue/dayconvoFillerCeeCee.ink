INCLUDE globals.ink
EXTERNAL GoToAppartment()
Hey there, new stuff, hows the day been treating ya? #speaker:CeeCee #mood:happy

I think i'm doing okay. #speaker:Graciana #mood:happy

Think you can do me a favor? #speaker:CeeCee

*[No problem. Let's do it.]
    ~affectionCC+=1
    ->EndConvo
*[Do it yourself.]
    ~affectionCC-=1
    ->EndConvo
*[No worries. I got it.]
    ~chaosCC+=1
    ->EndConvo

===EndConvo===
~convo_numberCC+=1
~GoToAppartment()
->DONE