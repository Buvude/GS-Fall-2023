//EXTERNAL GoToDiner()
// INCLUDE Intro_ORyan.ink
INCLUDE globals.ink
INCLUDE BADialogue.ink
// EXTERNAL mainORYAN()
// Would you like to retry the minigame?
//     *[Yes]
//         ->MainBAD
//     *[No]
        ->MainFail


===MainFail===
~affectionCS-=3
...oops... #speaker:Graciana #mood:sad #sfx:lostPoint

Ay, no worries. It takes a while for tha way of the food to start speakin' to ya. #speaker:Chef Swatts

...What does that even mean? #speaker:Graciana

Ya know, the way of the food... The flow... in ya blood... #speaker:Chef Swatts

......... #speaker:Graciana

Well, don' think 'bout it too much. Ya gonna get it eventually, ya'll see. #speaker:Chef Swatts
Anyways, go ahead an' take this burger out to tha customer, ya?

Got it... #speaker:Graciana #scg:black
(I take the burger out to the customer, and help Chef Swatts with some more prepwork and cleaning.) #ss:Chef Swatts:blank
~convo_numberCS=1
~StartO_Ryan()
->DONE