EXTERNAL EndGame()
EXTERNAL EndGame2()
==CreditsPlaceholder==
CREDITS:
Producer: Sol P.
Narrative Designers: Dom Malo, Sol P.
Programming: David Eisenberg.
Art: Rob Morrison, Jordan Carey
...
Did you know, each character has a secret Chaos ending? And getting all of them might make something special happen... 
If you would like more information on that you can ask for it now, otherwise your save will be erased because there is no more game.
Keep an ear out for this sound! #sfx:cosmicPoint
*[More Info]
->MoreInfo
*[Erase My Data]
~EndGame()  
->DONE
*[Quit Game (this will also erase data)]
~EndGame2()
->DONE

==MoreInfo==
What do you want to know?
*[Minigame Chaos Outcomes]
    ->MiniGameInfo
*[Info about Character Chaos Endings (Stats only for now)]
    ->CharacterInfo
*[Back]
    ->CreditsPlaceholder
->DONE

==MiniGameInfo==
What do you want to know about chaos outcomes in minigames? Keep in mind that they can only be triggered in the level 3 varients (hardest level) of each minigame. (vague hints are in the dialogue options, for the solution click on them)
*[How do I make a cosmic horror burger? (Burger Assembly Minigame)]
    Collect all the cosmic ingredients, in order of appearance they are:
    Bottom Bun of the Deep (black with tentacles)
    Pickled All seeing Eyes (white eyes)
    Biblically Accurate Greens (white/gold with eyes/black spots)
    Mystery meat (purple/black burger patty)
    Slime (green goop condiment)
    The Thing (a hand)
    Top Bun of the Deep (black with tentacles)
->MiniGameInfo
*[How do I throw the trash into the void? (Trash Throwing Minigame)]
   Throw the trash in the black hole which is the top most possible moving target. 
->MiniGameInfo
*[back]
->MoreInfo
->DONE
==CharacterInfo==
what stats do you want about the characters?
*[final chaos ending score]
    {chaosOR}/{chaosTotalOR} required for the Chaos game ending.
    ->CharacterInfo
*[Character chaos points aquired]
    {chaosCS}/{chaosTotalCS} required for Chef Swatts Chaos ending.
    {chaosN}/{chaosTotalN} required for NiCo's Chaos ending.
    {chaosF}/{chaosTotalF} required for Fred's Chaos ending.
    {chaosM}/{chaosTotalM} required for Morgan's Chaos ending.
    {chaosG}/{chaosTotalG} required for Himber's Chaos ending.
    {chaosOR}/{chaosTotalOR} required for... Something secret!

    ->CharacterInfo
*[back]
    ->MoreInfo
    
->DONE