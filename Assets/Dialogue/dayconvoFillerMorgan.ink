INCLUDE globals.ink
EXTERNAL GoToAppartment()
How may I... Help you... today? #speaker:Graciana #mood:fear

Yeah... #speaker:Morgan #mood:neutral

Could you bring to me

THE SOULS OF THE BROKEN, THE DAMNED AND UNSPOKEN! #speaker:Morgan #mood:angry

!!! #speaker:Graciana

Or just a slice of red velvet cake. #speaker:Morgan #mood:neutral

*[O-O-On it!]
    ~affectionM+=1
    ->EndConvo
*[(Scream incessantly for the rest of the work day)]
    ~affectionM-=1
    ->EndConvo
*[I'll get O'Ryan to get you that!]
    ~chaosM+=1
    ->EndConvo


===EndConvo===
~convo_numberM+=1
~GoToAppartment()
->DONE