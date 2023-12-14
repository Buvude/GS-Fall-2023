INCLUDE globals.ink
INCLUDE BADialogue.ink
~affectionCS-=3

// Would you like to retry the minigame?
//     *[Yes]
//         ~BAMLevel=0
//         ~currentConvo="cSD0"
//         ->MainBAD
//     *[No]
        ->MainFail0
    ===MainFail0===
Ay, don't worry, it takes a wee bit to get used to, ya? #speaker:Chef Swatts #mood:neutral

U-uh, yeah, I can see... #speaker:Graciana #mood:neutral
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
    -> DONE
