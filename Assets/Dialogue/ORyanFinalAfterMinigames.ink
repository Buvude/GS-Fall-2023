// INCLUDE globals.ink
INCLUDE GameEndBad.ink
INCLUDE GameEndGood.ink
INCLUDE GameEndChaos.ink
INCLUDE CreditsPlaceHolder.ink

===Oryanfinale===
... #speaker:O'Ryan
Come with me. #speaker:O'Ryan #mood:neutral

//transition to main diner

... #speaker:O'Ryan
Do you know what I am?

Uh... #speaker:Graciana #mood:think

//i don't think there's any reason to mechanically fit in the dialogue options having weights and affecting values & the ending
//these lil branching dialogue options are just for flavor, i guess
//unless you can think of something, but i think it's better to just have the ending determined by your overall performance

* [You're O'Ryan?]
    You're... O'Ryan? Obviously...? #speaker:Graciana #mood:think
    
    ... #speaker:O'Ryan
    Ha. Ha. Ha.
    Yes. I am indeed O'Ryan. But that is not what I am asking.
    
    Oh, uh... #speaker:Graciana
    
    It is fine. I did not expect you to know. #speaker:O'Ryan
    ->continuetheconvo
    
* [You're space?]
    You're... space? #speaker:Graciana
    Or, like, made of space?
    
    ... #speaker:O'Ryan
    Yes, in a sense. You are surprisingly almost correct.
    ->continuetheconvo
    
* [You're an alien?]
    You're... an alien? #speaker:Graciana
    
    ... #speaker:O'Ryan
    Incorrect.
    
    O-oh... #speaker:Graciana #mood:sad
    ->continuetheconvo

==continuetheconvo==
I come from The Great Void. Unlike our customers, or anyone else, I do not have any sort of "Home World." #speaker:O'Ryan
I was born from a cluster of stars, planets, and galactic energy. I simply appeared into existence one day.
I had no knowledge of who or where I was. There was only one thing I was sure of.

(One thing?) #speaker:Graciana #mood:think

I love food. Everything about it. #speaker:O'Ryan
The feel. The smell. The taste.
The way it is prepared. The way it is served.
It consumed my every waking thought. Yet, I had never seen a piece of food at this point.
But I knew I had to.
As I continued to float through The Great Void for almost a century, I passed by a floating structure.
It was a building. And there were people inside. Eating food.
It was the United Dimensions Headquarters, they were simply on a lunch break.
Do you know what I did next?

* [Introduced yourself?]
    You walked in and introduced yourself? #speaker:Graciana #mood:think
    
    ... #speaker:O'Ryan
    I suppose that is one way of putting it.
    ->oryanhungryboy
    
* [Stole their food?]
    ...You stole their food or something? #speaker:Graciana #mood:think
    
    ... #speaker:O'Ryan
    Yes. Exactly.
    
    Wait, actually? #speaker:Graciana #mood:neutral
    ->oryanhungryboy

==oryanhungryboy==
I snuck in through the cracks of the window when no one was looking. #speaker:O'Ryan
And in the empty conference room, I consumed the leftover scraps of a hamburger.
They came back in the room to see me hunched over on the table, covered in ketchup and grease.

(Oh boy, what a mental image...) #speaker:Graciana #mood:think

They were astonished. Not by me eating their food, but because they did not know what I was. #speaker:O'Ryan
I told them that I just appeared, and that I had no idea about anything civilized.
They took me in, and taught me all the things I needed to know about...
"Being a person."

Eventually, they let me start working at the United Dimensions.
Typically, every World has their own representative. But The Great Void did not have any native citizens.
Until me.

I oversee a variety of different establishments in The Great Void, but this Diner I personally opened and ran.
However. Overtime, interdimensional travel became more commonplace. There were more people to check in and out. More establishments were opening at a rapid pace.
The paperwork kept piling up, and I have not been able to dedicate the time to this Diner that it deserves.

{
-chaosOR>=6:
->ChaosGameEnd
-affectionOR>=0:
->GoodGameEnd
-else
->BadGameEnd
}

    -> END
