INCLUDE globals.ink
//INCLUDE TTMicroTestConvo.ink
INCLUDE TTmicroTestConvo.ink
// {weekDay=="Sun":
//     ->ToMiniGame    
// -else:
// I'm to tired to practice tonight, I'll wait until Sunday.#speaker:Graciana
// }
->ToMiniGame

===ToMiniGame===
    What do I want to practice?
    *[Burger cooking with Chef Swatts]
        ->DONE
    *[Taking out the Trash with CeCe]
        ->difficultySelection
        ->DONE
    *[Nevermind, I'll just stay here for now]
        Ok.
        ->END