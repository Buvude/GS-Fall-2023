
//EXTERNAL StartBAMicro()
INCLUDE globals.ink
INCLUDE BADialogue.ink
//INCLUDE EveningTest.ink

What level do you want to try? #speaker:Chef Swatts #mood:happy
    *[Level 1]
        ~convo_numberCS=0
        ->MainBAD
    *[Level 2]
        ~convo_numberCS=1
        ->MainBAD
    *[Level 3]
        ~convo_numberCS=2
        ->MainBAD
    ->DONE