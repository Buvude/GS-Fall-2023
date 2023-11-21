//#day:1 #CSConvo:0
INCLUDE globals.ink

->GameIntro
===GameIntro===
    ~dayVar=1
    ~weekDay="Tut"
    ~convo_numberCS=0
    (I enter through the portal, and in a moment I'm whisked into the building.) #speaker:Graciana
    (Here we are... The Portal Diner...) #speaker:Graciana #mood:think
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
    //MINIGAME HAPPENS HERE I DON'T KNOW HOW TO CALL IT LOL
    //also just for the sake of simplicity and also story it makes sense to just keep it in one ink file. splitting the dialogue between pass/fail on the first ever minigame is ehhh (also because it's an intro and i dont wanna make the player feel bad for fucking up)
    
    Ay, how're ya feelin'? #speaker:Chef Swatts #mood:neutral
    
    U-uh, okay I guess? #speaker:Graciana #mood:neutral
    (Does he have to fling it at me like that?!) #speaker:Graciana #mood:angry
    Also, why does the food look... like that? #speaker:Graciana #mood:think
    
    Whattya mean? #speaker:Chef Swatts #mood:neutral
    
    Like, y'know... Different? #speaker:Graciana
    
    Ay, we source all our food from a dimension deep in The Great Void--I ain't ever even heard of it before. #speaker:Chef Swatts
    Big Boss O'Ryan really likes to make sure it's only the highest quality of ingredients, ya?
    
    U-uh, yeah, I guess that makes sense... #speaker:Graciana
    Anyways...
    …When do we open? #speaker:Graciana #mood:think
    
    Oh! Ya! Soon! Like, 2 minutes! #speaker:Chef Swatts #mood:happy
    
    O-oh! #speaker:Graciana #mood:neutral
    
    Looks like they startin' to come in, look alive! #speaker:Chef Swatts
    Just go right up to 'em! Don't be shy!
    Some of 'em are a bit more talkative than others, they gonna try to talk ya ear off. #speaker:Chef Swatts #mood:neutral
    Jus' be a good listener, an' say what they wanna hear.
    Ya got it? #speaker:Chef Swatts #mood:happy
    
    Got it! #speaker:Graciana #mood:happy
    ~GoToDiner()
    
    ->END