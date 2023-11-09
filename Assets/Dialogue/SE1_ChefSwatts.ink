
//EXTERNAL StartBAMicro()
INCLUDE globals.ink
INCLUDE BADialogue.ink
//INCLUDE EveningTest.ink


//VAR tempHolder =""
->Main
===Main===
~convo_numberCS=0
Ey, <b>Graciana</b>! Think ya can give me some help real quick? #speaker:Chef Swatts #mood:neutral

* [Sure]

    Sure, why not. #speaker:Graciana #mood:neutral

    Perfect! Come come, prep this for me ya? #speaker:Chef Swatts

    Whatcha making? #speaker:Graciana #mood:happy

    Experimenting wit some pasta. I had an idea for a new kinda sauce. #speaker:Chef Swatts #mood:happy
    Here, prep these bombadoes for me?

    Bombadoes? ...You mean tomatoes? #speaker:Graciana #mood:think

    No no no, I mean bombadoes. BIG difference. #speaker:Chef Swatts #mood:neutral


    (He hands me a strange looking vegetable, and goes back to grabbing more ingredients. It's about the size of a normal tomato, except it's green, and small hairs are growing out of it... It's strangely damp too, and the skin is almost leathery.) #speaker:Graciana #mood:neutral

    (...How am I supposed to prep this?) #speaker:Graciana #mood:think
    
    ** [Peel it]
        // GOOD OPTION
        ~affectionCS=affectionCS+1
        (I take a potato skin peeler, and begin peeling away at the bombado.) #speaker:Graciana 
        (Piece by piece, the skin comes off with relative ease. The inside is almost gelatin-like.)
        (Chef Swatts turns back around, looking over my shoulder...)

        ... #speaker:Chef Swatts #mood:sad
        Whattya doin'?

        Uh... Prepping? #speaker:Graciana

        Kh... Khahahaha! #speaker:Chef Swatts #mood:happy
        I mean, at least you didn't make a mess!

        (Chef Swatts takes the bombado from my hand, and squeezes it over a bowl.) #speaker:Graciana

        (POP!) #speaker: 

        (The bombado pops in his hands, juice pouring out exessively into the bowl.) #speaker:Graciana

        These are from my homeworld, Dipterra. Ya supposed to pop 'em in your hands, and take the juice from it. #speaker:Chef Swatts #mood:neutral
        My bad, I shoulda told ya.
        
        No worries... #speaker:Graciana #mood:neutral
        (Chef Swatts takes the bowl and adds a handful of spices and herbs I barely recognize and pours it over the pasta, mixing it in.)
        (It doesn't look too different than your average pesto sauce, but still...)
        
        -> reconvene
    
    ** [Squeeze it]
        // CHAOTIC OPTION
        ~chaosCS=chaosCS+1
        (I take the bombado into a bowl and squeeze it with both hands.) #speaker:Graciana 

        (POP!) #speaker: 

        (It pops in my hand with barely any effort. Juices pour out of the bomado, and it shrivels up.) #speaker:Graciana

        Ey, there you go! You eat one of these before? #speaker:Chef Swatts #mood:happy

        I have no idea what this even is, I just kinda wanted to see what would happen... #speaker:Graciana

        They from my homeworld, Dipterra. The only way to eat 'em is to pop 'em in your hands, drink the juice & eat the remains of it. #speaker:Chef Swatts
        You figured it out instantly, that must be the way of tha food guiding ya! It's in ya blood!
        
        Ha, I wish... #speaker:Graciana #mood:sad
        It was just a lucky guess. I really don't know anything about cooking... I eat instant ramen most nights. #speaker:Graciana #mood:neutral

        Ay, but ramen is food, no? Ya still cookin' it, no? #speaker:Chef Swatts

        I guess, yeah... #speaker:Graciana #mood:think

        Gotta start somewhere, ya? #speaker:Chef Swatts

        Yeah, true... #speaker:Graciana #mood:happy
        (Chef Swatts takes the bowl and adds a handful of spices and herbs I barely recognize and pours it over the pasta, mixing it in.)
        (It doesn't look too different than your average pesto sauce, but still...)
        
        -> reconvene

    ** [Slice it]
        // BAD OPTION
        ~irritatedCS=irritatedCS+1
        (I grab a kitchen knife and bring it to the bombado. I barely even poke it with the knife, when...) #speaker:Graciana

        (SPLAT!) #speaker: 

        (...the bombado pops, exploding everywhere!) #speaker:Graciana
        (Juice coats the walls of the kitchen, not to mention all over myself, in my hair...)
        I... I... I'm s-so sorry, I didn't... #speaker:Graciana #mood:sad

        ... #speaker:Chef Swatts #mood:happy
        Ahahahaha!
        Ya have no idea what those are, do ya?

        ...I guess not... #speaker:Graciana

        Ya, I prolly shoulda warned ya... They're from my home, Dipterra. #speaker:Chef Swatts #mood:neutral
        Ya supposed to squeeze 'em into a bowl, and let the juice fill it.

        That... would've been good to know... #speaker:Graciana

        Lemme help ya clean up, it's on me that ya didn't know. #speaker:Chef Swatts

        ... #speaker:Graciana

        -> reconvene

* Nah
    -> DONE

=== reconvene ===

So, how much crazy food like this exists in your homeworld? #speaker:Graciana #mood:think

Crazy? #speaker:Chef Swatts #mood:neutral

S-sorry, I mean... Well... #speaker:Graciana #mood:sad
There isn't anything like this where I'm from. #speaker:Graciana #mood:neutral

Ah, well, ya know, there's bombadoes, drawtherries, trapples, gongagas... #speaker:Chef Swatts
Really, I could go on an' on an' on. Big boss O'Ryan don't wanna bother with ordering 'em, so once a week I go back home to scavenge 'em to use here. Just a lil sprinke is all I need!

...Scavenge? #speaker:Graciana #mood:think

Ya, scavenge. There ain't no supermarket where I'm from, babeh! #speaker:Chef Swatts #mood:happy
I gotta grab what I can before one of 'em nasty spider clans spot me! #speaker:Chef Swatts #mood:angry

Oh, I see... #speaker:Graciana #mood:neutral
Wait, spider clans?! #speaker:Graciana #mood:think

Ya, the spider clans rule Dipterra. They don't take well to us flyfolk. #speaker:Chef Swatts #mood:neutral
As in, they hunt and kill us! Ahahaha! #speaker:Chef Swatts #mood:happy

... #speaker:Graciana

I laugh, but they make life very hard, ya? All us other insectfolk live in, well, the place they call "fear." #speaker:Chef Swatts #mood:sad

Has anyone done anything about it? Like, is there any kind of... Law? #speaker:Graciana #mood:think

Ahaha! That's funny! #speaker:Chef Swatts #mood:happy
Nah. #speaker:Chef Swatts #mood:neutral
Nothin' like that. Every bug for 'emself. If ya get eaten, ya get eaten. That's how it is.
We try not to worry 'bout it, ya know? 

That makes sense, yeah... #speaker:Graciana #mood:neutral

Life's too short to stress the small stuff, ya? #speaker:Chef Swatts

(...Death is considered "small stuff"?) #speaker:Graciana #mood:think
(Different cultures, I guess. The multiverse is big, it makes sense that there's even bigger differences.)
...

Yo, Graciana. Ya done staring off into space? #speaker:Chef Swatts

!! #speaker:Graciana #mood:neutral
Yeah, sorry. I guess it never really sank in how different things are around the multiverse.

Ya ya, I hear ya. Took me a while to understand that food ain't rare like it is back home. #speaker:Chef Swatts
Speakin' of, help me wit' this burger, ya? 

O-oh, right, yeah! #speaker:Graciana #mood:happy
~currentConvo="cSD1"
->MainBAD

// Order up! Looks like we got an order of: #speaker:Chef Swatts
//     ~tempHolder=pop_random(BBuns)
//     For the bottom bun we've got: {tempHolder} #BBun:{tempHolder}
//     ~tempHolder=pop_random(Pickles)
//     For the pickles we've got: {tempHolder} #Pickles:{tempHolder}
//     ~tempHolder=pop_random(Greens)
//     For the lettuce we've got: {tempHolder}#lettuce:{tempHolder}
//     ~tempHolder=pop_random(patty)
//     For the patty we've got: {tempHolder}#patty:{tempHolder}
//     ~tempHolder=pop_random(Condiments)
//     For the Ketchup/Mustard we've got: {tempHolder}#Condiments:{tempHolder}
//     ~tempHolder=pop_random(Veggies)
//     For the veggie topping we've got: {tempHolder}#veggie:{tempHolder}
//     ~tempHolder=pop_random(TBuns)
//     For the top bun we've got: {tempHolder}#TBun:{tempHolder}
//     ~StartBAMicro()
->DONE
    

// === function pop_random(ref _list) 
//     ~ temp el = LIST_RANDOM(_list) 
//     // ~ _list -= el
//     ~ return el 
    

