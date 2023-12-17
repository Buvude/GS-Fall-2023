INCLUDE globals.ink
INCLUDE BADialogue.ink
EXTERNAL StartTTMicro()
~QuickLoad()

{winState=="loss":
    ->retry
}

->DecideFate
==retry==
// Would you like to retry the minigame?
//     *[Yes]
//         {currentConvo=="FMG3":
//         ~StartTTMicro()
//         ->DONE
//         }
//         ->MainBAD
//     *[No]
        ->DecideFate

==DecideFate==
{
-currentConvo=="FMG1":
    {
    -winState=="won":
    ~affectionF+=2
    ~convo_numberF=1
    ->pass1
    -winState=="loss":
    ~affectionF-=2
    ~convo_numberF=1
    ->fail1
    }
-currentConvo=="FMG2":
    {
    -winState=="won":
     ~affectionF+=3
     ~convo_numberF=2
    ->pass2
    -winState=="loss":
    ~affectionF-=3
    ~convo_numberF=2
    ->fail2
    }
-currentConvo=="FMG3":
    {
    -winState=="chaos":
    ~chaosF+=4
    ~convo_numberF=3
    ->chaos
    -winState=="won":
    ~affectionF+=4
    ~convo_numberF=3
    ->pass3
    -winState=="loss":
    ~affectionF+=4
    ~convo_numberF=3
    ->fail3
    }
}
==pass1==
Nice, I think I'm pretty good at this! #speaker:Graciana #mood:happy
(I think Fred would like a burger like this... If he could eat them...)
~StartO_Ryan()
->DONE
==pass2==
I just keep getting better, huh? #speaker:Graciana #mood:happy
(I wonder what Fred would think about a burger like this...?)
~StartO_Ryan()
->DONE
==pass3==
Awesome, nailed all of 'em! #speaker:Graciana #mood:happy #ecg: 
(I think Fred would find this pretty fun...)
~StartO_Ryan()
->DONE
==fail1==
Oof, that could've been better... #speaker:Graciana #mood:sad
(At least Fred wasn't here to see that...)
~StartO_Ryan()
->DONE
==fail2==
This is pretty tough, huh... #speaker:Graciana #mood:sad
(Fred would probably say something to cheer me up, I bet...)
~StartO_Ryan()
->DONE
==fail3==
Jeez, it's tough getting these in... #speaker:Graciana #mood:sad #ecg: 
(I'm sure Fred would probably ace it, since he's used to space...)
~StartO_Ryan()
->DONE
==chaos==
Huh... I wonder... Where does that black hole take the trash? #speaker:Graciana #mood:think #ecg: 
(Maybe Fred knows something about it? Since he's a star?)
~StartO_Ryan()
->DONE