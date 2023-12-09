INCLUDE globals.ink
INCLUDE BADialogue.ink
~QuickLoad()
{
-currentConvo=="GMG1":
    {
    -winState=="won":
    ->pass1
    -winState=="loss":
    ->fail1
    }
-currentConvo=="GMG2":
    {
    -winState=="won":
    ->pass2
    -winState=="loss":
    ->fail2
    }
-currentConvo=="GMG3":
    {
    -winState=="chaos":
    ->chaos
    -winState=="won":
    ->pass3
    -winState=="loss":
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