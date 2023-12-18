INCLUDE globals.ink
// uncomment when done

Hello once again, human! We must speak at once! #speaker:Himber #mood:neutral

* [What's up?]
    -> FinalsGnomiesConversation
    
* [Uh, nope!]
Uh, sorry, maybe later? #speaker:Graciana #mood:think
(Definitely not later.) #speaker:Graciana #mood:neutral
    -> DONE
==FinalsGnomiesConversation==
~convo_numberG=4
~QuickSave()
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
~affectionG=affectionG+4
Honestly...? #speaker:Graciana #mood:think #sfx:gainedPoint
You're kind of a jerk. #speaker:Graciana #mood:angry
Not just to me, but to Hograt, too.
I feel like every time you've been in here, you say or do something nasty to either me, Hograt, or both.
And I don't get it. You're a gnome, for crying out loud. #speaker:Graciana #mood:neutral
The typical gnomes I know of are all happy, giddy, y'know, stuff like that. #speaker:Graciana #mood:think
But you're just bitter. #speaker:Graciana #mood:neutral
And this whole Gnomestack thing... #speaker:Graciana #mood:think
I don't get it. But if it's something Hograt genuinely wants to take part in, then you shouldn't be so hard on him.
You mentioned that this is how things are in your culture, but is everyone this rude about it? #speaker:Graciana #mood:angry

... #speaker:Himber #mood:neutral
A lot of it is pressure from the Planar Society... But I understand your meaning, human.
    ->PreEnd
==bad1==
~affectionG=affectionG-4
I mean, you're okay, I guess... #speaker:Graciana #mood:sad #sfx:lostPoint

...Okay? #speaker:Himber

Y-yeah, I mean... #speaker:Graciana
You're just a customer, at the end of the day. This is all pretty standard to me at this point...

So you find my behavior normal? #speaker:Himber #mood:neutral

I mean, comparatively? Yeah, I guess... #speaker:Graciana #mood:neutral

I see... #speaker:Himber

Why're you asking, anyways? #speaker:Graciana #mood:think

Oh, no reason in particular. I was just curious of what a lower lifeform thought of a higher intellectual being such as myself! #speaker:Himber #mood:happy

(Ugh, and right after I try to be decent to him...) #speaker:Graciana #mood:sad

Hograt as well, though since we are a conjoined entity, I already know how he feels. #speaker:Himber #mood:neutral

Do you really...? #speaker:Graciana #mood:angry

But of course! #speaker:Himber #mood:happy

(I look down at Hograt...) #speaker:Graciana #mood:think
(I mean, he doesn't look absolutely miserable... But definitely not perfect...)

Besides, we cannot split up at this point. #speaker:Himber #mood:neutral
We have already created a union between Gnomes with the Planar Society. The consequences would be dire if we were to break that.
    ->PreEnd
==chaos1==
~chaosG=chaosG+2
Well... #speaker:Graciana #mood:think #sfx:cosmicPoint
I think you're kinda silly, honestly. #speaker:Graciana #mood:neutral

... #speaker:Himber #mood:neutral
Silly...?

Yeah, honestly. #speaker:Graciana #mood:happy
I mean, two different gnomes stacked on top of each other... #speaker:Graciana #mood:think
One of them doesn't talk, the other one has an atittude...
I mean, c'mon, it's kinda funny. #speaker:Graciana #mood:neutral

I do not understand what you find amusing, human. We are considered very normal back on Tometopia! #speaker:Himber #mood:angry

Say, are there any Gnomestacks with three gnomes? #speaker:Graciana #mood:think

Absolutely not! The Planar Society only accepts a union between two Gnomes. No more, and no less. #speaker:Himber
    ->PreEnd
==PreEnd==
The Planar Society? #speaker:Graciana #mood:think

Yes, The Planar Society. #speaker:Himber #mood:neutral
They oversee Tometopia. They are the beings in charge of law and order.
In our world, forming a union between a topgnome and a subgnome is customary. And The Planar Society oversees this event. #speaker:Himber
It is unknown what happens if one is to break this union, but it can only be suspected as not being very good.

Not very good? #speaker:Graciana #mood:think
What do they do, kick you out or something?

No, even worse... #speaker:Himber #mood:sad
//deivert to ending calculation
{
-chaosG>=chaosTotalG:
    ->GnomiesChaosEnd
-affectionG>=0:
    ->GnomiesGoodEnd
-else:
    ->GnomiesBadEnd
}

==GnomiesGoodEnd==
~convo_numberOR+=1
~convo_numberG+=1
~affectionOR+=1

But, that is irrelevant. #speaker:Himber #mood:neutral
There is something I must admit to you, human...
No, I'm sorry... #speaker:Himber #mood:sad
I've been referring to you as human this whole time, haven't I?
Tell me... What is your name? #speaker:Himber #mood:neutral

Oh, yeah, I guess I never told you... #speaker:Graciana #mood:think
It's Graciana. #speaker:Graciana #mood:neutral

Graciana... #speaker:Himber #mood:neutral
That is a lovely name! #speaker:Himber #mood:happy
... #speaker:Himber #mood:sad
I must apologize for my behavior these past few days. #speaker:Himber #mood:neutral

...Oh? #speaker:Graciana #mood:think
(This is unexpected...)

Yes. I have been rather unpleasant these past few days. #speaker:Himber #mood:sad
I understand there is no excuse for my actions, but you must understand...
I have been put under great pressure by The Planar Society.
For you see, I am the leader's son. And I am supposed to take his place in the upcoming year.
But... #speaker:Himber #mood:sad

But? #speaker:Graciana

But, Hograt and I have not yet achieved our maximum potential. Or at least, the potential that is required by The Planar Society. #speaker:Himber #mood:neutral
Every member is a finely established and polished Gnomestack! #speaker:Himber #mood:happy
... #speaker:Himber #mood:sad
Except for us. #speaker:Himber #mood:neutral
And in trying to achieve that goal, I have become bitter. Not just to you, but to Hograt especially. #speaker:Himber #mood:sad 

Moreso than you, I must apologize to Hograt. #speaker:Himber #mood:neutral
... #speaker:Himber #mood:sad

(Himber climbs down from atop Hograts head, and looks at him face to face...!) #speaker:Graciana #scg:black

... #speaker:Himber
Hograt, I am truly sorry for my behavior these past few months.
I have let the pressures of my kin get underneath my skin. I had promised myself that I would surpass than my father in both rank and demeanor, but with the way I have treated you, I have become no better than him.
The way I have acted is unacceptable, and unbecoming of a topgnome such as myself.
More importantly...
It is unbecoming of a subgnome to be treated in such a manner.
You endured a lot throughout your lifetime, moreso than I ever have.
You deserve more respect, and I am truly, deeply sorry. I desperately hope for your forgiveness, despite me not deserving a drop of it.

... #speaker:Hograt
...
...Thank...you...

!! #speaker:Graciana
(Himber holds his arms out to Hograt, and the two Gnomes embrace in a hug that feels as if it could last forever.)

... #speaker:Hograt
I... forgive... you...

(They pull away, and Hograt gently grabs Himber, placing him atop his head once more.) #speaker:Graciana

... #speaker:Himber #ecg:blank

... #speaker:Graciana #mood:neutral

Thank you, Graciana. #speaker:Himber 

Me? #speaker:Graciana

Yes, you! #speaker:Himber #mood:happy
I cannot express it with the right words, but you pushed me towards this realization. And I can never properly repay you for that. #speaker:Himber #mood:neutral
In fact, I made this exclusively for you...

(He holds out a bracelet, made of beautiful stones...) #speaker:Graciana #pu:gfb
//show bracelet teehee

This was made using both the stones from above the surface, and beneath the surface, of Tometopia. #speaker:Himber #mood:neutral
This is a forever token of our gratitude.

Well, thank you... #speaker:Graciana
(This is now probably the nicest piece of jewelry I own...) #speaker:Graciana #mood:think
(Actually, I think it's the only piece of jewelry I own...)

Now, if you will excuse us, we shall be off. #speaker:Himber #pd: 
We must take a break from training, to spend some...
Quality time? #speaker:Himber #mood:happy

Yeah, I think that sounds about right. #speaker:Graciana

Until we meet again, Graciana! #speaker:Himber #mood:happy

(Hograt walks out of the Diner, happily waving at me with Himber atop his head, also waving slightly.) #speaker:Graciana #mood:happy

Huh... #speaker:Graciana #mood:think
I'm just glad I could help.

~GoToAppartment()
    -> DONE
==GnomiesBadEnd==
~convo_numberOR+=1
~convo_numberG+=1
~affectionOR-=1
But it is of no concern. The thought would never even cross my mind. #speaker:Himber #mood:neutral
And even with his lesser IQ, Hograt still wouldn't dare to disrespect The Planar Society. #speaker:Himber #mood:happy
Isn't that right, Hograt?
...

...? #speaker:Graciana #mood:think

...Hograt, I am not sensing any response from you! #speaker:Himber
Please, you must communicate with me via your internal monologue! How many times have we gone over this?! #speaker:Himber #mood:angry
We will never achieve enlightenment with your poor attitude!
You need to start putting in more effort! I cannot do everything for you!
...Hograt? #speaker:Himber

... #speaker:Hograt #scg:black
I've... Had... Enough...

Hograt?! #speaker:Himber
Don't you dare raise your voice at me! You are not to communicate with me verbally, you are to--

(In a moment, Hograt reaches his arms up above his head...) #speaker:Graciana
(...And grabs Himber!)

Hograt?! What are you doing?! Put me back up this instant! #speaker:Himber #mood:angry

(With one hand, Hograt grasps Himber like a baseball, winds up...) #speaker:Graciana
<i><b>CRASH!</i></b> #speaker:window
(...And flings him out the window!) #speaker:Graciana
//having a sound here would be neat
//adding more sound effects in general would be something i should look into in these last few days, would help the game feel less empty & give scenes more impact
...I accept my consequences... #speaker:Hograt

Hograt... #speaker:Graciana
(Without another word, Hograt slowly shambles out of the Diner, walking through the portal.) #ecg: #ss:Himber:blank
//also hide himber here whoops

... #speaker:Graciana #mood:fear
... #speaker:Graciana #mood:neutral
Oh, Himber's hat... #speaker:Graciana #mood:neutral #pu:gh
//show hat popup here
...
I'm not sure what to make of this...
... #pd:
I should probably tell O'Ryan about the broken window...
... #esfo

    ->DONE
==GnomiesChaosEnd==
~convo_numberOR+=1
~convo_numberG+=1
~chaosOR+=1

But that is irrelevant. #speaker:Himber #mood:neutral
We have discovered a new power beyond our originally perceived strength. #speaker:Himber #mood:happy

A new power? #speaker:Graciana #mood:think

Yes! We have trained extensively for the past few days. In fact, we may be able to pull it off right here, in this very establishment! #speaker:Himber

R-right here? Right now? #speaker:Graciana #mood:fear

But of course! If we can ascend to a greater power here in this establishment, we could do it anywhere! #speaker:Himber

Should I take cover or something? #speaker:Graciana #mood:fear

No time! #speaker:Himber #mood:happy 

Hograt, are you ready? #speaker:Himber

... #speaker:Hograt
//you might wanna create a hograt speaker tag
//it doesn't need to have any sprites because the screen will be black whenever he's talking
//uhhhh if possible, also a "Gnomies" speaker tag? when they ascend that's what they're gonna be known as
//rob is currently making a new sprite that can fill that slot
//it's a really funny buff gnome

...Yes... #speaker:Hograt #scg:black
...I am ready...

!! #speaker:Graciana #mood:fear
(In a split second, a blinding light fills the Diner. The two of them morph into each other seamlessly, as if made of light.)
(The light dies down, and suddenly I am faced with...)

... #ecg: #speaker:Gnomies #mood:chaos 
//i forget, does "blank" clear the cg? i hope so 🧍
//also oh my god i can put emojis in my ink comments??? wish i knew that earlier, i would've gone crazy🙇
//watch this end up bricking the entire game lmao 😪

... #speaker:Graciana #mood:fear

... #speaker:Gnomies

... #speaker:Graciana
Oh my god.

Greetings, Graciana. #speaker:Gnomies

W-wait, now that I think about it, I never told you my name... #speaker:Graciana #mood:think

Yes. We have ascended beyond the need for feeble conversation topics. #speaker:Gnomies
We can read into your mind and soul. You are Graciana, you are 20 years old, you live on Earth, and your Origin is unknown.

U-unknown?! #speaker:Graciana #mood:fear
What do you mean?! #speaker:Graciana #mood:angry

This information is irrelevant to our current situation. #speaker:Gnomies
We must inform The Planar Society of our accomplishment posthaste.

W-what will happen once you do? #speaker:Graciana #mood:think

They will likely congratulate us on our accomplishment, and be astounded as to how we accomplished it. #speaker:Gnomies
After this celebration, they will likely ask for our assistance in instructing them all how to achieve this ascenscion.
In a matter days, all of Gnome society on Tometopia will change forever.
I shall lead my people even further beyond our original perceived potential.

W-well, uh... #speaker:Graciana #mood:think
Congratulations...? #speaker:Graciana #mood:neutral
(Did I do the right thing here...? Is this what they want...?) #speaker:Graciana #mood:think

Yes, Graciana. You did. #speaker:Gnomies

!! #speaker:Graciana #mood:fear
R-right, you said you can read my mind now... #speaker:Graciana #mood:sad

Worry not. This would not have been possible without your assistance. #speaker:Gnomies

<i>My</i> assistance?! #speaker:Graciana #mood:think

Indeed. #speaker:Gnomies
Without your assistance, our limited Gnome minds would not be able to perceive a power greater than what we were.
But you were able to lead us to this power.
Therefore, you must possess a power even greater than what we could comprehend.
I kneel to you, O' Graciana The Powerful.

U-uh, t-thank you...? #speaker:Graciana #mood:neutral
(Funny, just a few days ago, Himber was just yelling about how "low intelligence" I am...) #speaker:Graciana #mood:think
(But now, he's bowing to me...?)
(He? They? It's both Himber <i>and</i> Hograt, right?)
(...They've probably ascended past the "need for pronouns," I bet...)

Please, refer to us as "Gnomies." #speaker:Gnomies
This is the name you gave us earlier. We have grown a fondness for it, as we now comprehend your intellectual prowess.
Thank you, Graciana. Please, take this as a momento of this occasion. #pu:gmb
//call that magic bag here✨

This was Himber's bag of magical components. We do not require it anymore, since we have ascended past the need to fuel our arcane abilities. #speaker:Gnomies

(Gnomies places the bag in my hands. It's surprisingly a lot heavier than it looks...) #speaker:Graciana #mood:neutral

Even if using it is trivial to a being of your power, we still would like for you to keep it, as a momento of our accomplishment. #speaker:Gnomies #pd: 
Thank you, Graciana. We will be leaving now.

(And just like that...) #speaker:Graciana #mood:neutral
//ITS SO LATE I PROMISE ILL ADD THE TAG FOR HIDING GNOMIES SPRITE LATER ;-;

(The absolute unit of a Gnome exits the Diner...) #ss:Gnomies:blank
...
Man, what the hell did I just witness? #speaker:Graciana #mood:think
... #esfo:

    ->DONE