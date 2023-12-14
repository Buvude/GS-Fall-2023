INCLUDE globals.ink
// EXTERNAL GoToAppartment()
Gnomies says placeholder
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
// ~GoToAppartment()
~StartO_Ryan()
->DONE