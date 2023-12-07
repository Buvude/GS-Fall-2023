INCLUDE globals.ink
EXTERNAL GoToAppartment()
GOOD MORNING!!! #speaker:Fred #mood:pump

Morning, Fred. Would you like anything right now? #speaker:Graciana #mood:neutral

Another bottle of lava lamp, blue please! #speaker:Fred #mood:galaxy

*[I'll get you some!]
    ~affectionF+=1
    ->EndConvo
*[We only have orange!]
    ~affectionF-=1
    ->EndConvo
*[I'll take care of that.]
    ~chaosF+=1
    ->EndConvo


===EndConvo===
~convo_numberF+=1
~GoToAppartment()
->DONE