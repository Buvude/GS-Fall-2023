//#day:2 #CSConvo:1
// EXTERNAL StartO_Ryan()
EXTERNAL GoToAppartment()
==mainORYAN==
~StartO_Ryan()
(Phew... Finally, after a long first day...) #speaker:Graciana #mood:neutral
(Just gotta clean and close up...)
(...)
(Suddenly, the entrance portal flashes and opens up!)
// Portal Sound
E-excuse me, we're closing now, so if you could please-- #speaker:Graciana #mood:think
(A massive, towering figure exits the portal.)
// Show O'Ryan Neutral
(It's almost like... if a galaxy was a person...) #speaker:Graciana #mood:fear
S-sir? Uh... Ma'am? Uh...

... #speaker:???//set to slower text speed for O'Ryan while they are ???

(I can't tell if it has eyes, but I somehow feel them staring into my soul...) #speaker:Graciana
C-can I help you...?

... #speaker:???
Graciana, correct?

(Who the hell is this?!) #speaker:Graciana
Uh...

    * [Yea, I'm Graciana.]
        Y-yeah, that's me... #speaker:Graciana
        
        ... #speaker:???
        I am O'Ryan. #speaker:O'Ryan #mood:happy
        I am the owner of The Portal Diner.
        
        !! #speaker:Graciana
        Oh! Right! Yeah, of course! Hi, uh, thank you, for, uh, hiring me, and, and, uh, I'm Graciana!
        
        ... #speaker:O'Ryan
        I know.
        
        (They hold out an envelope without saying anything else, and I slowly reach for it.) #speaker:Graciana
        
        Payment for today. #speaker:O'Ryan
        ...Keep it up.
        
        T-thank you! #speaker:Graciana
        ->continue
        
    * [Graciana who?]
        Who's Graciana? I-I've never heard that n-name before... #speaker:Graciana
        
        ... #speaker:???
        I am O'Ryan. #speaker:O'Ryan 
        I am the owner of The Portal Diner.
        
        !!!! #speaker:Graciana
        O-oh! Y-yeah! Right, s-sorry, I, uh, yeah, uh, I am, uh, Graciana, ha, ha, s-sorry, I, uh, j-just--
        (O'Ryan holds out an envelope without a word. They gesture for me to take it.)
        
        Payment. For today. #speaker:O'Ryan #mood:annoyed
        ...
        Graciana.
        ->continue
        
==continue==
    (In complete silence, O'Ryan turns and leaves the Diner.)#speaker:Graciana
    ...Sheesh...
    (I finish closing up and head on home, envelope in hand.)
    // You got paid [amount] Øllars!
    
    // ->NextDayVarAdjust//temp until appartment is set up
    ~convo_numberCS=1
    ~GoToAppartment()
    ->DONE
