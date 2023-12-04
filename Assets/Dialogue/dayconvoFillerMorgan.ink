INCLUDE globals.ink
// EXTERNAL GoToAppartment()
Morgan says fuck.jpeg
*[good option]
    ~affectionM+=1
    ->EndConvo
*[bad option]
    ~affectionM-=1
    ->EndConvo
*[chaos option]
    ~chaosM+=1
    ->EndConvo


===EndConvo===
~convo_numberM+=1
// ~GoToAppartment()
~StartO_Ryan()
->DONE