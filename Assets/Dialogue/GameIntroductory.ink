//#day:1 #CSConvo:0
INCLUDE globals.ink
INCLUDE BADialogue.ink

->GameIntro
===GameIntro===
    ~dayVar=1
    ~weekDay="Tut"
    ~convo_numberCS=0
    ~QuickSave()

    Apron, check! Glasses, check! #speaker:Graciana #bgm:dinMorning
    Okay, I think I'm ready!
    ...Oh yeah, the employee handbook... I never looked at it...
    Do I really need to...?
    * [No]
    Reading's for chumps, I'm sure I can figure it out.
    How hard could it possibly be? It's just waiting tables.
        ->TheGameBegins
    * [Yes (Instructions)]
    Okay, let's see here...
//i really wanna make this a different font color to signify that it's being "read" but it's 2am and my brain cannot process digging through inky documentation right now, i promise i'll come back to this ;-;
    (To proceed in a conversation, simply "click" anywhere--but you already knew that.)
    (To set "auto mode," press the "A" key. To skip through conversations--if you must--press the "Right Control" key. To view the "log," press the "Tab" key. To "pause," press the "P" or "Escape" key. Note that the "pause screen" will not pause minigames, as to prevent any "dishonesty.")#esfo:
    (The "Game" will automatically "save" at the end of each day, when you return to your apartment and go to sleep.)
    Okay, I think that's the basics... There's a bit more though, in case I need it...
    ** [I'm all set!]
    Boooooring! I already knew all that!
    It's just waiting tables, how hard could it possibly be?
        ->TheGameBegins
    ** [(Read more)]
    (When in the Dining Room, to initiate a new conversation, simply "click" on the customer you wish to speak with.)
    (During conversation, you may be given an opportunity to respond. These are called "choices")
    ...No duh...
    (Your conversations may hold serious ramifications to the fate of the customer, so be sure to pay attention!)
    (Some beings are able to <b>hear</b> the outcome of their choices, but this is a rare skill not many have.)
    (And who knows, their fate may affect you as well in the end... So do your best!)
    (At the end of a conversation, you will be tasked with a job in the Diner--The instructions will be visible when they appear, so don't panic!)
    (And lastly, the most crucial instruction of all--)
    Jeez, this thing just goes on and on, does it ever stop?! There's like 20 more pages...
    Whatever, I can figure it out! It's just waiting tables, how hard could it be?
        ->TheGameBegins
        
==TheGameBegins==

    (I enter through the portal, and in a moment I'm whisked into the building.) #speaker:Graciana 
    (Here we are... O'Ryan's Diner...) #speaker:Graciana #mood:think 
    (Today’s my first day as a waitress here. It isn’t much, but it’s easy money while I look for an actual job.)
    (I still haven’t met or even seen the owner; I interviewed online. They said to find a “fly guy,” whatever that means–) 
    
    Ey! We not open yet! Ya gonna have to wait! How’d ya get in here? The portal shoulda been locked! #speaker:???
    
    Uh, I-I work here now, today’s m-my first day… My n– #speaker:Graciana #mood:fear
    
    OH! Ya! You’re Graciana, right? #speaker:???
    
    (Suddenly, the kitchen door swings open, and before me stands, literally… a “fly guy.”) #speaker:Graciana
    
    Why didn’t ya start with that? I’m Chef Swatts, I’m tha head chef–and only–chef here! #speaker:Chef Swatts #mood:happy 
    
    H-hi, I’m Graciana–#speaker:Graciana #mood:neutral
    
    Ya, I know. Big boss O’Ryan told me you’d be coming in today. #speaker:Chef Swatts #mood:neutral
    
    Right… Where are they? #speaker:Graciana #mood:think
    
    Ya, big boss O’Ryan doesn’t come in really. They manage from afar, you know. #speaker:Chef Swatts
    They got they fancy job at the United Dimensions, so he don’t got the time for us lower scraps, haha! #speaker:Chef Swatts #mood:happy
    
    Ha… Yeah… #speaker:Graciana #mood:neutral
    So is it just us? #speaker:Graciana #mood:think
    
    Basically, ya. Cece comes in sometimes too, but I mainly run things around here… For now, at least. #speaker:Chef Swatts #mood:neutral
    Big boss O’Ryan wants me to be tha new owner, but ehhhhh. I don’t wanna deal with allat. I just like being near tha food… mmmm…… food……
    
    Right… Uh… #speaker:Graciana #mood:neutral
    
    Ya look like ya got somethin' special in ya. #speaker:Chef Swatts #mood:neutral
    
    ... #speaker:Graciana
    What? #speaker:Graciana #mood:think
    
    Like, tha special flow is in ya blood. #speaker:Chef Swatts
    
    ...Special flow? #speaker:Graciana
    (...What is this dude talking about?)
    //these options r just introducing the player to branching they wont have any variables to them
    *[Like, cooking?]
    Do you mean like, cooking? #speaker:Graciana #mood:think
    
    Ay, somethin' like that, ya! #speaker:Chef Swatts #mood:happy
    The way of the food... movin' through ya blood!
    Get what I mean, ya?
    
    I... think? #speaker:Graciana #mood:think
    (I have no idea...) #speaker:Graciana #mood:sad
    
    ->minigametime
    
    *[Are you hitting on me?]
    ...Are you hitting on me or something? #speaker:Graciana
    
    Hitting ya? Why would I hit ya? Ya just got here! #speaker:Chef Swatts
    
    ... #speaker:Graciana
    (I am so confused right now.) #speaker:Graciana #mood:sad
    ->minigametime
    
    ==minigametime==
    Here, come back to tha kitchen wit' me. Let's get cookin'! #speaker:Chef Swatts #mood:happy
    
    R-right now? Also, I'm a waiter, I don't think I'm supposed to--#speaker:Graciana #mood:neutral
    
    Nonsense! Jus' a lil practice round, ya? #speaker:Chef Swatts
    
    Uh, okay... #speaker:Graciana
    //do minigame and continue with the pass or fail
   ~BAMLevel=0
   ~currentConvo="cSD0"
   ~QuickSave()
   ->MainBAD
    ->END