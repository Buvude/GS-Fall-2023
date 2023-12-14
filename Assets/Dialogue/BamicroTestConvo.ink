
//EXTERNAL StartBAMicro()
INCLUDE globals.ink
INCLUDE BADialogue.ink
//INCLUDE EveningTest.ink

~currentConvo="Arcade"
What level do you want to try? #speaker:Chef Swatts #mood:happy
    *[Level 1]
        ~BAMLevel=0
        ->MainBAD
    *[Level 2]
        ~BAMLevel=1
        ->MainBAD
    *[Level 3]
        ~BAMLevel=2
        ->MainBAD
    ->DONE