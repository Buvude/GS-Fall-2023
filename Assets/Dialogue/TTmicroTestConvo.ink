//INCLUDE globals.ink
INCLUDE TTDialogue.ink

===difficultySelectionT===
    What difficulty do I want to try?
        *[Level 1]
            ~TTMLevel=1
            // ~currentConvo="practiceT"
            //~QuickSave()
            -> MainTTM
        *[Level 2]
            ~TTMLevel=2
            // ~currentConvo="practiceT"
            ~QuickSave()
            -> MainTTM
        *[Level 3]
            ~TTMLevel=3
            // ~currentConvo="practiceT"
            ~QuickSave()
            -> MainTTM
        ->DONE