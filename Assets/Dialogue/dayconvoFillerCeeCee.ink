INCLUDE globals.ink
// EXTERNAL GoToAppartment()
CeeCee says placeholder
*[good option]
    ~affectionCC+=1
    ->EndConvo
*[bad option]
    ~affectionCC-=1
    ->EndConvo
*[chaos option]
    ~chaosCC+=1
    ->EndConvo

===EndConvo===
~convo_numberCC+=1
// ~GoToAppartment()
~StartO_Ryan()
->DONE