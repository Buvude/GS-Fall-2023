
INCLUDE globals.ink
EXTERNAL GoToAppartment()
How's the leg today NiCo? #speaker:Graciana #mood:sad

Rustier than before, thanks... #speaker:Nico #mood:sad

Want your usual chips? #speaker:Graciana #mood:neutral

Sure. #speaker:Nico #mood:neutral

*[Here. I'm getting better at prepping 'em.]
    ~affectionN+=1
    ->EndConvo
*[Sorry, should be better next time.]
    ~affectionN-=1
    ->EndConvo
*[These should be spicier than before.]
    ~chaosF+=1
    ->EndConvo



===EndConvo===
~convo_numberN+=1
~GoToAppartment()
->DONE