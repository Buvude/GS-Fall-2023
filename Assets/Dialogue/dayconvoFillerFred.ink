INCLUDE globals.ink
EXTERNAL GoToAppartment()
Fred says fuck.jpeg
*[good option]
    ~affectionF+=1
    ->EndConvo
*[bad option]
    ~affectionF-=1
    ->EndConvo
*[chaos option]
    ~chaosF+=1
    ->EndConvo


===EndConvo===
~convo_numberF+=1
~GoToAppartment()
->DONE