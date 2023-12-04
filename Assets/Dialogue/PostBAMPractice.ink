INCLUDE ToMinigames.ink
 the outcome of the minigame was: {winState}
 ~currentConvo=""
what would you like to do?
*[try again]
    ~currentConvo="practiceB"
    ~StartBAMPractice()
    ->DONE
*[change minigame]
    ->ToMiniGame
*[return to appartment]
    Time to relax.
    ->DONE