INCLUDE globals.ink
EXTERNAL StartTTMicro()
//uncomment line 1 when done writing. choices dont work properly in the editor otherwise

Hello once again, human! I see you simply cannot resist me! #speaker:Himber #mood:happy

* [Sure...]
    ->GnomiesConvoStart2
* [Nope, see ya!]
Hmph! #speaker:Himber #mood:angry
    -> DONE

==GnomiesConvoStart2==
I guess, sure... #speaker:Graciana #mood:neutral

Perfect! You know what I want by now, yes? #speaker:Himber #mood:neutral

Of course I know! #speaker:Graciana #mood:happy
Lingonberry Sweet Pie, right?

Precisely! #speaker:Himber #mood:happy

Anything for Hograt this time? I think there's still some of that old broken table left? #speaker:Graciana #mood:think
(Hograt looks up at me and nods--but Himber looks angrier than usual...) #speaker:Graciana #mood:neutral

Hograt! How many times have I mentioned this! Moving your head sends the balance awry! You must keep steady! #speaker:Himber #mood:angry
And you, human! I have told you countless times by now! What have I said about distracting Hograt?!
Subgnomes are not capable of focusing on multiple things at once! They are very simple, one-track-minded beings!
Hograt especially! You mustn't disrupt his focus, for his intelligence is not the same as a being such as myself!
He is a lower lifeform, such as yourself!

* [Apologize]
    ->bad1
* [Defend Hograt]
    ->good1
* [Defend myself]
    ->chaos1

==good1==
~affectionG=affectionG+4
You know, you shouldn't talk to Hograt like that! #speaker:Graciana #mood:angry #sfx:GainedPoint
He carries you around on his head non-stop, and all you do is yell at him!
Does he even want to be there? Are you like, holding him captive or something?!

Captive...? #speaker:Himber #mood:neutral
Human, do not accuse me so lightly of things you know nothing of. #speaker:Himber #mood:angry

Then tell me, what's the deal with you? Hograt too! #speaker:Graciana #mood:angry
    ->gnomestuck
==bad1==
~affectionG=affectionG-4
M-my bad, I just... #speaker:Graciana #sfx:LostPoint

You cannot comprehend the intricacies of this bond, human! #speaker:Himber #mood:angry
As a Gnomestack, this is simply the way things are! This is how we are meant to be!
    ->gnomestuck
==chaos1==
~chaosG=chaosG+4
Hey, don't talk to me like that! #speaker:Graciana #mood:angry #sfx:CosmicPoint
I'm not your subordinate, I'm a person, just like you!

Hmph! No, you are a human! #speaker:Himber #mood:neutral
I am a Gnomestack! I am objectively above you! #speaker:Himber #mood:happy

What the hell is a Gnomestack?! #speaker:Graciana #mood:angry
    ->gnomestuck
    
==gnomestuck==
Sigh... #speaker:Himber #mood:sad
Human, must I explain everything to you?
I am what is known as a "Gnomestack." #speaker:Himber #mood:neutral
I feel like it is fairly self explanatory, no?

(A Gnomestack...?) #speaker:Graciana #mood:think

* [A stack of gnomes?]
    ->good2
* [A stack of power.]
    ->chaos2
* [A stack of... Pancakes?]
    ->bad2
==good2==
~affectionG=affectionG+4
C'mon, I'm not that dumb. You're two gnomes stacked on top of eachother, obviously that's what a Gnomestack is. #speaker:Graciana #mood:happy #sfx:GainedPoint

I see your human brain is rather sharp! At least, compared to a topgnome such as myself! #speaker:Himber #mood:happy

So like, what does it even mean to be a Gnomestack? If I stand on top of another human, it's not a "Humanstack," I'm just standing on someone's head. #speaker:Graciana #mood:think

Again, you keep comparing yourself to us, without understanding how different our species is... #speaker:Himber #mood:neutral
As I have mentioned multiple times prior, topgnomes excel at arcane arts and intellect. And subgnomes, they excel at physical strength.
If we combine this power...
We can ascend further beyond our own strengths! #speaker:Himber #mood:happy

* [A new form then...?]
    ->chaos3
* [I doubt it.]
    ->bad3
* [What about Hograt?]
    ->good3
==bad2==
~affectionG=affectionG-4
Like... #speaker:Graciana #mood:neutral #sfx:LostPoint
A stack of pancakes? #speaker:Graciana #mood:think

... #speaker:Himber #mood:neutral
Speaking to you is a waste of my higher intellect.
Obviously not like a stack of pancakes! #speaker:Himber #mood:angry
It's in the name! Gnomestack! We are two different species of gnomes stacked on top of eachother!
How do you not get it?!

Wow, no need to yell... #speaker:Graciana #mood:sad
(...Why <i>did</i> I say that?) #speaker:Graciana #mood:think

If we stack on top of each other, we can amplify our capabilities! It is a matter of efficiency! #speaker:Himber #mood:angry
We ascend further beyond our own strengths! #speaker:Himber #mood:happy

* [A new form then...?]
    ->chaos3
* [I doubt it.]
    ->bad3
* [What about Hograt?]
    ->good3
==chaos2==
~chaosG=chaosG+4
A stack of raw power. #speaker:Graciana #mood:happy #sfx:CosmicPoint

Haha! #speaker:Himber #mood:happy
In a sense, I suppose you are right!
With my magical capabilities, and Hograt's physical capabilities, we are quite the stack of power!
But, more literally, we combine our capabilities and become one entity--a Gnomestack! #speaker:Himber #mood:neutral

* [A new form then...?]
    ->chaos3
* [I doubt it.]
    ->bad3
* [What about Hograt?]
    ->good3
==good3==
~affectionG=affectionG+4
Okay, sure, that makes sense I guess... #mood:Graciana #mood:think #sfx:GainedPoint
But what about Hograt?

...What about him? #speaker:Himber #mood:neutral

The way you talk down to him, called him your "steed," the way you're <i>literally</i> standing on his head... #speaker:Graciana #mood:think
Look, I'm not gonna pretend that I know anything about how gnomes work, but surely you don't have to be so rude to him! #speaker:Graciana #mood:think

Rude? I have not been rude! I am simply determined to the effort of forming the perfect Gnomestack! #speaker:Himber #mood:angry

And what about Hograt? How does he feel about it all? Does he also want to form the perfect Gnomestack? #speaker:Graciana #mood:think

Of course Hograt does! We've been at this for decades! If he did not want this, it's not as if I'm holding him captive! #speaker:Himber #mood:happy

(I look down at Hograt, and he nods at me...) #speaker:Graciana #mood:think
(I can't get a good read on his face, honestly...) 
(He seems determined...) 
(...But also bothered by something.) #speaker:Graciana #mood:sad
    -> ByeByeGnomies
==bad3==
~affectionG=affectionG-4
Somehow, I doubt that. #speaker:Graciana #mood:neutral #sfx:LostPoint

What do you mean, human? What does your feeble, human mind doubt? #speaker:Himber #mood:neutral

I doubt that any of this "Gnomestack" business is real! #speaker:Graciana #mood:angry
It just seems to me like you're using Hograt for your own personal gain! He deserves better than this!

Human, again, you should not speak on ideals you know nothing of. #speaker:Himber #mood:neutral
Gnomestacking is tradition in our culture. Every subgnome, if blessed to escape from beneath the surface of Tometopia, must find their matching topgnome. It's simply just how we partake in our society. 
Just because it differs from what you expect, does not make it incorrect. #speaker:Himber #mood:angry

Sure, whatever... #speaker:Graciana #mood:angry
(I still think he's full of it... Poor Hograt deserves way better than this...)
(I look down at Hograt, and I can't get a good read on his face, honestly...)
(He seems bothered by something...) #speaker:Graciana #mood:think
(...But also looks as if he's glaring me down, confused...)
    -> ByeByeGnomies
==chaos3==
~chaosG=chaosG+4
But... #speaker:Graciana #mood:think #sfx:CosmicPoint
You look the same. #speaker:Graciana #mood:neutral

What do you mean? Of course we look the same! #speaker:Himber #mood:angry

I dunno, I would just think if you're truly "combining your powers..." #speaker:Graciana #mood:think
Shouldn't you have like, a new form or something?

A new form? #speaker:Himber #mood:neutral

Yeah, like, physically you should reflect that power, right? #speaker:Graciana #mood:think
In some anime--
... #speaker:Graciana #mood:neutral
I mean...
In some mythological books I've read, whenever a being goes even further beyond, something about them should change, physically! #speaker:Graciana #mood:happy
Whether it's a whole new body, or something as simple as their hair changing... #speaker:Graciana #mood:think
And if it's two beings combining their power, they fuse and become one being...
Something on changes to reflect their new found power, to differentiate from what they were before!
But you two are just two gnomes stacked on top of each other... #speaker:Graciana #mood:sad
How do you know you're <i>really</i> activating your true potential? #speaker:Graciana #mood:think

Hrm... #speaker:Himber #mood:neutral
Human, I never though I would say this, however...
You do make a compelling point! #speaker:Himber #mood:happy
Hograt and I will have to look further into this, to unlock our true potential!
    -> ByeByeGnomies
==ByeByeGnomies==
Well, it appears we have stayed longer than planned! We must get going! #speaker:Himber #mood:neutral
Onward, Hograt!
We shall be back, human! #speaker:Himber #mood:happy

(Himber drops a pile of gold coins on the table, and exits with Hograt beneath him.) #speaker:Graciana #mood:neutral
...#ss:Himber:blank
Wait... #speaker:Graciana #mood:think
...I never got him his pie... 
...
Oh well. #speaker:Graciana #mood:neutral

~TTMLevel=3
~timeOfDay="afternoon"
~currentConvo="GMG3"
~QuickSave()
~StartTTMicro()
    -> DONE