INCLUDE globals.ink
// EXTERNAL GoToAppartment()
Fred says placeholder
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
// ~GoToAppartment()
~StartO_Ryan()
->DONE
