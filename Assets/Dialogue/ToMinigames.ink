INCLUDE globals.ink
//INCLUDE TTMicroTestConvo.ink
INCLUDE TTmicroTestConvo.ink
EXTERNAL QuickLoad()
EXTERNAL StartBAMPractice()
~QuickLoad()
 {
    -currentConvo=="practiceT":
    -currentConvo=="practiceB":
    -else:
        {
        -weekDay=="Sun":
        ->ToMiniGame
        -else:
            I'm to tired to practice tonight, I'll wait until Sunday.#speaker:Graciana
        }
        
}   


// {
// -currentConvo=="practiceT":
// -currentConvo=="practiceB":
// -else:
//     ->ToMiniGame
// }

===ToMiniGame===
    What do I want to practice?
    *[Burger cooking]
        ~currentConvo="practiceB"
        ~StartBAMPractice()
        ->DONE
    *[Taking out the trash]
        ~currentConvo="practiceT"
        ->difficultySelectionT
        ->DONE
    *[Nevermind, I'll just stay here for now]
        Ok.
        ->END