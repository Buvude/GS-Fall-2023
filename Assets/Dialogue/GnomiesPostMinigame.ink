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
        {currentConvo=="GMG3":
        ~StartTTMicro()
        ->DONE
        }
        ->MainBAD
    *[No]
        ->DecideFate

==DecideFate==
{
-currentConvo=="GMG1":
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
-currentConvo=="GMG2":
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
-currentConvo=="GMG3":
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
//bam bam trash
==pass1==
Alright, looks like I'm getting it! #speaker:Graciana #mood:happy
(I doubt Himber would compliment me for this.)
~StartO_Ryan()
->DONE
==pass2==
Getting better and better! #speaker:Graciana #mood:happy
(I wonder... Gnomestacks, burger stacks... There's a joke there, probably.)
~StartO_Ryan()
->DONE
==pass3==
Alright, all set! #speaker:Graciana #mood:happy
(Y'know, I could probably toss Himber like this...)
~StartO_Ryan()
->DONE
==fail1==
Jeez, that's rough... #speaker:Graciana #mood:sad
(I wouldn't wanna disappoint Hograt...)
~StartO_Ryan()
->DONE
==fail2==
Yikes... Guess I'm not great at stacking... #speaker:Graciana #mood:sad
(I can already imagine what Himber would say...)
~StartO_Ryan()
->DONE
==fail3==
Welp, close enough...? #speaker:Graciana #mood:sad
(If I were throwing Himber instead, I'm sure I'd be more accurate...)
~StartO_Ryan()
->DONE
==chaos==
Hm... I wonder where that black hole leads to...? #speaker:Graciana #mood:think
(Maybe I can throw Himber in there, and find out...)
//i'm making jokes about graciana throwing himber to kinda foreshadow the bad ending lmao
~StartO_Ryan()
->DONE