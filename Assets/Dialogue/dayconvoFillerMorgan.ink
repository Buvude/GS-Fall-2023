INCLUDE globals.ink
// EXTERNAL GoToAppartment()
Morgan says placeholder
*[good option]
    ~affectionM+=1
    ->EndConvo
*[bad option]
    ~affectionM-=1
    ->EndConvo
*[chaos option]
    ~chaosM+=2
    ->EndConvo


===EndConvo===
~convo_numberM+=1
// ~GoToAppartment()
~StartO_Ryan()
->DONE