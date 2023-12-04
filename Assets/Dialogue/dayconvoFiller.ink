INCLUDE globals.ink

Gnomies says fuck.jpeg
*[good option]
    ~affectionG+=1
    ->EndConvo
*[bad option]
    ~affectionG-=1
    ->EndConvo
*[chaos option]
    ~chaosG+=1
    ->EndConvo


===EndConvo===
~convo_numberG+=1
->NextDayVarAdjust