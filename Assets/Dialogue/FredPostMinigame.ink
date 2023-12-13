INCLUDE globals.ink
INCLUDE BADialogue.ink
EXTERNAL StartTTMicro()
~QuickLoad()

{winState=="loss":
    ->retry
}

->DecideFate
==retry==
Would you like to retry the minigame?
    *[Yes]
        {currentConvo=="FMG3":
        ~StartTTMicro()
        ->DONE
        }
        ->MainBAD
    *[No]
        ->DecideFate

==DecideFate==
{
-currentConvo=="FMG1":
    {
    -winState=="won":
    ~affectionG+=2
    ~convo_numberG=1
    ->pass1
    -winState=="loss":
    ~affectionG-=2
    ~convo_numberG=1
    ->fail1
    }
-currentConvo=="FMG2":
    {
    -winState=="won":
     ~affectionG+=3
     ~convo_numberG=2
    ->pass2
    -winState=="loss":
    ~affectionG-=3
    ~convo_numberG=2
    ->fail2
    }
-currentConvo=="FMG3":
    {
    -winState=="chaos":
    ~chaosG+=4
    ~convo_numberG=3
    ->chaos
    -winState=="won":
    ~affectionG+=4
    ~convo_numberG=3
    ->pass3
    -winState=="loss":
    ~affectionG+=4
    ~convo_numberG=3
    ->fail3
    }
}
==pass1==
You won1!
~StartO_Ryan()
->DONE
==pass2==
You won2!
~StartO_Ryan()
->DONE
==pass3==
You won3!
~StartO_Ryan()
->DONE
==fail1==
You lost1.
~StartO_Ryan()
->DONE
==fail2==
You lost2.
~StartO_Ryan()
->DONE
==fail3==
You lost3.
~StartO_Ryan()
->DONE
==chaos==
You got chaotic.
~StartO_Ryan()
->DONE