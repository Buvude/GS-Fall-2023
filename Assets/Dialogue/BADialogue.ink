EXTERNAL StartBAMicro()
INCLUDE globals.ink


VAR tempHolder =""
->Main
===Main===
// ~Random_Holder=Random(1,3)
    Order up! Let's take a lookie here... #speaker:Chef Swatts
    ~tempHolder=pop_random(BBuns)
    For the bottom bun, it's {tempHolder}. #BBun:{tempHolder}
    ~tempHolder=pop_random(Pickles)
    With {tempHolder} on top of that... #Pickles:{tempHolder}
    ~tempHolder=pop_random(Lettuce)
    For them greens, they want {tempHolder}. #lettuce:{tempHolder}
    ~tempHolder=pop_random(patty)
    And of course, they want that {tempHolder} patty. #patty:{tempHolder}
    ~tempHolder=pop_random(Condiments)
    ...With a lil squirt of {tempHolder}...#Condiments:{tempHolder}
    ~tempHolder=pop_random(Veggies)
    Veggies? Let's see... {tempHolder}...#veggie:{tempHolder}
    ~tempHolder=pop_random(TBuns)
    And the bun to top it all off... {tempHolder}.#TBun:{tempHolder}
    ~StartBAMicro()
    Aight! Graciana, get ready! It's comin' in hot!
->DONE

=== function pop_random(ref _list) 
    ~ temp el = LIST_RANDOM(_list) 
    // ~ _list -= el
    ~ return el 
    
