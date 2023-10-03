EXTERNAL StartBAMicro()
INCLUDE globals.ink

~StartBAMicro()
VAR tempHolder =""
->Main
===Main===
// ~Random_Holder=Random(1,3)
    Order up! Looks like we got an order of: #speaker:Chef Swatts
    ~tempHolder=pop_random(BBuns)
    For the bottom bun we've got: {tempHolder} #BBun:{tempHolder}
    ~tempHolder=pop_random(Pickles)
    For the pickles we've got: {tempHolder} #Pickles:{tempHolder}
    ~tempHolder=pop_random(Lettuce)
    For the lettuce we've got: {tempHolder}#lettuce:{tempHolder}
    ~tempHolder=pop_random(patty)
    For the patty we've got: {tempHolder}#patty:{tempHolder}
    ~tempHolder=pop_random(Condiments)
    For the Ketchup/Mustard we've got: {tempHolder}#Condiments:{tempHolder}
    ~tempHolder=pop_random(Veggies)
    For the veggie topping we've got: {tempHolder}#veggie:{tempHolder}
    ~tempHolder=pop_random(TBuns)
    For the top bun we've got: {tempHolder}#TBun:{tempHolder}
    ~StartBAMicro()
    Alright, it's go time!
->DONE

=== function pop_random(ref _list) 
    ~ temp el = LIST_RANDOM(_list) 
    // ~ _list -= el
    ~ return el 
    
