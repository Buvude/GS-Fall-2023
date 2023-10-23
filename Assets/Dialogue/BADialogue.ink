EXTERNAL StartBAMicro()



VAR tempHolder =""
//->MainBAD
===MainBAD===
    *stop the Dialogue
    
    {
    -convo_numberCS==0:
        Order up! Let's take a lookie here... #speaker:Chef Swatts
        ~tempHolder=pop_random(BBuns1)
        For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles1)
        With {tempHolder} on top of that... #Pickles:{tempHolder}
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
        ~StartBAMicro()
        Aight! Graciana, get ready! It's comin' in hot!
    -convo_numberCS==1:
        Order up! Let's take a lookie here... #speaker:Chef Swatts
        ~tempHolder=pop_random(BBuns1)
        For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
        ~tempHolder=pop_random(Pickles1)
        With {tempHolder} on top of that... #Pickles:{tempHolder}
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
        ~StartBAMicro()
        Aight! Graciana, get ready! It's comin' in hot!
}

// ~Random_Holder=Random(1,3)
    
->DONE

=== function pop_random(ref _list) 
    ~ temp el = LIST_RANDOM(_list) 
    // ~ _list -= el
    ~ return el 
    
