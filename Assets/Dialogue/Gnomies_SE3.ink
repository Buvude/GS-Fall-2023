//INCLUDE globals.ink
// uncomment when done

Hello once again, human! We must speak at once! #speaker:Himber #mood:neutral

* [What's up?]
    -> FinalsGnomiesConversation
    
* [Uh, nope!]
Uh, sorry, maybe later? #speaker:Graciana #mood:think
(Definitely not later.) #speaker:Graciana #mood:neutral
    -> DONE
==FinalsGnomiesConversation==
Hey, what's up Gnomies? #speaker:Graciana #mood:happy

... #speaker:Himber #mood:neutral
What did you just call me.

Uh, y'know, Gnomies? 'Cause there's like, the two of you? #speaker:Graciana

I do not understand, human. But that is irrelevant. #speaker:Himber
Tell me...
... #speaker:Himber #mood:sad
What do you think of me? #speaker:Himber #mood:neutral

(That's an odd question out of nowhere...) #speaker:Graciana #mood:neutral
(What do I think of Himber...?) #speaker:Graciana #mood:think

* [You're silly!]
    ->chaos1
* [You're okay...]
    ->bad1
* [You're a jerk.]
    ->good1

==good1==
~affectionG=affectionG+8
Honestly...? #speaker:Graciana #mood:think #sfx:GainedPoint
You're kind of a jerk. #speaker:Graciana #mood:angry
Not just to me, but to Hograt, too.
I feel like every time you've been in here, you say or do something nasty to either me, Hograt, or both.
And I don't get it. You're a gnome, for crying out loud. #speaker:Graciana #mood:neutral
The gnomes I know of are all happy, giddy, y'know, stuff like that. #speaker:Graciana #mood:think
But you're just bitter. #speaker:Graciana #mood:neutral
And this whole Gnomestack thing... #speaker:Graciana #mood:think
I don't get it. But if it's something Hograt genuinely wants to take part in, then you shouldn't be so hard on him.
You mentioned that this is how things are in your culture, but is everyone this rude about it? #speaker:Graciana #mood:angry
==bad1==
~affectionG=affectionG-8
I mean, you're okay, I guess... #speaker:Graciana #mood:sad #sfx:LostPoint

...Okay? #speaker:Himber

Y-yeah, I mean... #speaker:Graciana
You're just a customer, at the end of the day. This is all pretty standard to me at this point...

So you find my behavior normal? #speaker:Himber #mood:neutral

I mean, comparatively? Yeah, I guess... #speaker:Graciana #mood:neutral

I see... #speaker:Himber

Why're you asking, anyways? #speaker:Graciana #mood:think

Oh, no reason in particular. I was just curious of what a lower lifeform thought of a higher intellectual being such as myself! #speaker:Himber #mood:happy

(Ugh, and right after I try to be decent to him...) #speaker:Graciana #mood:sad

Hograt as well, though since we are a conjoined entity, I already know how he feels.

Do you really...? #speaker:Graciana #mood:angry

But of course! #speaker:Himber #mood:happy

==chaos1==
~chaosG=chaosG+2
Well... #speaker:Graciana #mood:think #sfx:CosmicPoint
I think you're kinda silly, honestly. #speaker:Graciana #mood:neutral

... #speaker:Himber #mood:neutral
Silly...?

Yeah, honestly. #speaker:Graciana #mood:happy
I mean, two different gnomes stacked on top of each other... #speaker:Graciana #mood:think
One of them doesn't talk, the other one has an atittude...
I mean, c'mon, it's kinda funny. #speaker:Graciana #mood:neutral

I do not understand what you find amusing, human. We are considered very normal back on Tometopia! #speaker:Himber #mood:angry


Say, are there any Gnomestacks with three gnomes? #speaker:Graciana #mood:think
==PreEnd==











