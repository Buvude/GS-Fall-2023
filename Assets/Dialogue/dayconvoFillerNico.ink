INCLUDE globals.ink

Nico says fuck.jpeg
*[good option]
    ~affectionN+=1
    ->EndConvo
*[bad option]
    ~affectionN-=1
    ->EndConvo
*[chaos option]
    ~chaosF+=1
    ->EndConvo



===EndConvo===
~convo_numberN+=1
->NextDayVarAdjust