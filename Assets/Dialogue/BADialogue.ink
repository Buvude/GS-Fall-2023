EXTERNAL StartBAMicro1()
EXTERNAL StartBAMicro2()
EXTERNAL StartBAMicro3()



VAR tempHolder =""
//->MainBAD
===MainBAD===
    //TODO replace variable here
    

    {
    -BAMLevel==0:
    // ~Random_Holder=Random(1,3)
        Order up! Let's take a lookie here... #speaker:Chef Swatts #mood:neutral
        ~tempHolder=pop_random(BBuns1)
        For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles1)
        for the pickle, they want it as {tempHolder} on top of that... #Pickles:{tempHolder}
        ~tempHolder=pop_random(Greens1)
        For them greens, they want {tempHolder}. #lettuce:{tempHolder}
        ~tempHolder=pop_random(patty1)
        And of course, they want that {tempHolder} patty. #patty:{tempHolder}
        ~tempHolder=pop_random(Condiments1)
        ...With a lil squirt of {tempHolder}...#Condiments:{tempHolder}
        ~tempHolder=pop_random(Veggies1)
        Veggies? Let's see... {tempHolder}...#veggie:{tempHolder}
        ~tempHolder=pop_random(TBuns1)
        And the bun to top it all off... {tempHolder}.#TBun:{tempHolder}
        ~StartBAMicro1()
        Aight! Graciana, get ready! It's comin' in hot! #speaker:Chef Swatts
->DONE
    -BAMLevel==1:
        Order up! Let's take a lookie here... #speaker:Chef Swatts #mood:neutral
        ~tempHolder=pop_random(BBuns2)
        For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles2)
        With {tempHolder} on top of that... #Pickles:{tempHolder}
        ~tempHolder=pop_random(Greens2)
        For them greens, they want {tempHolder}. #lettuce:{tempHolder}
        ~tempHolder=pop_random(patty2)
        And of course, they want that {tempHolder} patty. #patty:{tempHolder}
        ~tempHolder=pop_random(Condiments2)
        ...With a lil squirt of {tempHolder}...#Condiments:{tempHolder}
        ~tempHolder=pop_random(Veggies2)
        Veggies? Let's see... {tempHolder}...#veggie:{tempHolder}
        ~tempHolder=pop_random(TBuns2)
        And the bun to top it all off... {tempHolder}.#TBun:{tempHolder}
        ~StartBAMicro2()
        Aight! Graciana, get ready! It's comin' in hot! #speaker:Chef Swatts
->DONE
    -BAMLevel==2:
         Order up, just a heads up, you won't have time to look at the order once I start tossin'! Let's take a lookie here... #speaker:Chef Swatts #mood:neutral
        ~tempHolder=pop_random(BBuns3)
        For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles3)
        With {tempHolder} on top of that... #Pickles:{tempHolder}
        ~tempHolder=pop_random(Greens3)
        For them greens, they want {tempHolder}. #lettuce:{tempHolder}
        ~tempHolder=pop_random(patty3)
        And of course, they want that {tempHolder} patty. #patty:{tempHolder}
        ~tempHolder=pop_random(Condiments3)
        ...With a lil squirt of {tempHolder}...#Condiments:{tempHolder}
        ~tempHolder=pop_random(Veggies3)
        Veggies? Let's see... {tempHolder}...#veggie:{tempHolder}
        ~tempHolder=pop_random(TBuns3)
        And the bun to top it all off... {tempHolder}.#TBun:{tempHolder}
        ~StartBAMicro3()
        Aight! Graciana, get ready! It's comin' in hot! #speaker:Chef Swatts
->DONE
      -BAMLevel==3:
         Make me a burger, no peaking at the order once I start tossing ingredients. #speaker:O'Ryan #mood:neutral
        ~tempHolder=pop_random(BBuns3)
        bottom is {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles3)
        With {tempHolder} on top #Pickles:{tempHolder}
        ~tempHolder=pop_random(Greens3)
        with {tempHolder}. #lettuce:{tempHolder}
        ~tempHolder=pop_random(patty3)
        and {tempHolder} patty. #patty:{tempHolder}
        ~tempHolder=pop_random(Condiments3)
        squirt of {tempHolder}...#Condiments:{tempHolder}
        ~tempHolder=pop_random(Veggies3)
        and {tempHolder}...#veggie:{tempHolder}
        ~tempHolder=pop_random(TBuns3)
        And {tempHolder} on top.#TBun:{tempHolder}
        ~StartBAMicro3()
        prepare yourself, there will be no redos. #speaker:O'Ryan
->DONE
}


=== function pop_random(ref _list) 
    ~ temp el = LIST_RANDOM(_list) 
    // ~ _list -= el
    ~ return el 
    
