INCLUDE globals.ink
INCLUDE BADialogue.ink
EXTERNAL StartTTMicro()
~QuickLoad()

// {winState=="loss":
//     ->retry
// }

->DecideFate
==retry==
// Would you like to retry the minigame?
//     *[Yes]
//         {currentConvo=="GMG3":
//         ~StartTTMicro()
//         ->DONE
//         }
//         ->MainBAD
//     *[No]
        ->DecideFate

==DecideFate==
{
-currentConvo=="MMG1":
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
-currentConvo=="MMG2":
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
-currentConvo=="MMG3":
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
Nice, scored! #speaker:Graciana #mood:happy
(I wonder if Morgan would be good at this. She's got a bunch of tentacles... Can she grab with them?)
~StartO_Ryan()
->DONE
==pass2==
This burger's lookin' good! #speaker:Graciana #mood:happy
(Morgan can eat real food, right? I wonder what she'd think of a burger...)
~StartO_Ryan()
->DONE
==pass3==
I'm doin' great at this! #speaker:Graciana #mood:happy
(Maybe Morgan would feel better if she tried this, I'm feelin' pretty good...)
~StartO_Ryan()
->DONE
==fail1==
Yikes, I made a mess... #speaker:Graciana #mood:sad
(I'm glad Morgan isn't my boss, I'd be terrified of messing up...)
~StartO_Ryan()
->DONE
==fail2==
This burger looks... Interesting... #speaker:Graciana #mood:sad
(I wonder, would Morgan eat this? I'd think worse food tastes more like human souls...)
~StartO_Ryan()
->DONE
==fail3==
Wuh oh... #speaker:Graciana #mood:sad
(I'm sure Morgan would have a bit to say about my performance here...)
~StartO_Ryan()
->DONE
==chaos==
Aaaand there goes the trash... #speaker:Graciana #mood:think
(I wonder if Morgan knows anything about this black hole...?)
~StartO_Ryan()
->DONE