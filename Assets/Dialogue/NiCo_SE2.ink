INCLUDE globals.ink
->start
==start==
Hey NiCo! #speaker:Graciana #mood:neutral

... #speaker:NiCo #mood:neutral
Hey, Graciana. #speaker:NiCo

* [How's it going?]
    ->convostart
* [Oopsie, nevermind...]
...Guess not... #speaker:NiCo
    -> DONE
    
==convostart==
How're you holding up? #speaker:Graciana

Same old. Still chugging along. #speaker:NiCo

Yeah, I feel that... #speaker:Graciana
How's the leg doing? #speaker:Graciana #mood:think

Not great. It's been getting worse, actually. #speaker:NiCo

Getting worse? How so? #speaker:Graciana

Screws keep coming undone, and the metal keeps bending in a weird way. #speaker:NiCo
I've been tripping all day today, too. It's been jangling up my internals a bit too much. Which is rough, considering that's already not too great. #speaker:NiCo #mood:sad

What's wrong with your internals? #speaker:Graciana #mood:think
You got like, a virus or something?

... #speaker:NiCo #mood:neutral
Very funny. #speaker:NiCo #mood:smug

(That was supposed to be genuine... I got no idea how you work, dude.) #speaker:Graciana #mood:sad

I'm one of the first gens. #speaker:NiCo #mood:neutral

Like, an older model? #speaker:Graciana #mood:think

Yes. I was one of the first to get roboticized. As such, I'm a little more archaic than other models--In some ways. #speaker:NiCo
It's interesting... You'd think that because I'm an older model, I would've ran my course years ago.
But some would say that the older models are built better than the newer ones--Not as highly mass produced yet, so they couldn't cheap out on the parts...
Now they churn out as many as possible, since they're in such high demand--because you'll die in the toxic environment without it. #speaker:NiCo #mood:angry

But, now you're, uh... #speaker:Graciana #mood:neutral

Yes, I'm starting to hit my limit, I guess. #speaker:NiCo #mood:smug
They don't exactly manufacturer the parts for my model anymore. My only hope is getting them via an unofficial reseller, which-- #speaker:NiCo #mood:neutral

Is absurdly expensive, and would make you financially worse than you are physically? #speaker:Graciana #mood:think

... #speaker:NiCo #mood:smug

I don't think our worlds are all that different, honestly. #speaker:Graciana #mood:neutral
Yours is just... A bit further along than mine.

Really? How so? #speaker:NiCo

* [Scalpers!]
    ->bad1
* [Culture...]
    ->chaos1
* [Corporations.]
    ->good1
    
==good1==
~affectionN=affectionN+4
The way big corporations treat their employees like garbage. #speaker:Graciana
Honestly, one of the main reasons why I wanted to work out in The Great Void is just so I didn't have to succumb to a monopoly.
The idea of a "small local business" is more or less dead where I'm from. #speaker:Graciana #mood:sad

...I hardly even know what that is. #speaker:NiCo #mood:neutral

My point exactly! #speaker:Graciana #mood:angry
Bigger corporations have the money to do whatever they want. Threatened by a smaller company? They'll just buy them out, or drive them into bankruptcy! #speaker:Graciana #mood:angry

Sounds like you have an equivalent of Tundra in your world, don't you? #speaker:NiCo

A whole bunch of them. It's only a matter of time until they start going after eachother. #speaker:Graciana
There's one in particular that'll probably end up taking over, but for legal reasons I probably shouldn't say any names. #speaker:Graciana #mood:neutral

Do they listen in on you, too? #speaker:NiCo

Not yet... #speaker:Graciana #mood:think
Soon though, probably. #speaker:Graciana #mood:neutral

It sounds like your world isn't too far off from mine. #speaker:NiCo

Yeah, exactly. #speaker:Graciana
Are there any other companies at all? Or is everything just ran by Tundra. #speaker:Graciana #mood:think

Yes, it's all Tundra-owned. #speaker:NiCo #mood:sad

Was there ever a time when it wasn't? #speaker:Graciana

Back when I was initially roboticized, there were a few others. But that was so long ago, I can hardly remember what any of them were called. #speaker:NiCo #mood:neutral

* [...How old ARE you?!]
    ->good2
* [You need to break free!]
    ->chaos2
    
==bad1==
~affectionN=affectionN-3
Scalpers always ruining everything. That's a big problem on Earth. #speaker:Graciana

Oh, right, yes. I suppose so. #speaker:NiCo #mood:smug

You can never find what you need without some jerk buying it before you, and jacking up the price far beyond what it should sell for. #speaker:Graciana

Yes, I suppose that's a problem that's universal. #speaker:NiCo #mood:neutral
When you have a world where every drop of money is the difference between life and death, people will do whatever it takes to exploit that--Whether for a quick buck, or to survive.

I imagine it's even harder when you're trying to find parts, since that's actually essential. #speaker:Graciana
Scalpers on Earth jack up the prices of collectibles and video games and stuff. It's annoying, but at least it's not essential parts I need to live.

Yes, you have no idea how irritating it is to try to find a part that doesn't cost an arm and a leg. #speaker:NiCo #mood:angry

... #speaker:Graciana #mood:neutral
Do you mean that like-- #speaker:Graciana #mood:think

No, not literally! #speaker:NiCo

Okay, okay! #speaker:Graciana #mood:sad
Can you blame me for asking?

No... Not really. #speaker:NiCo #mood:sad

Exactly. #speaker:Graciana #mood:happy

In any case, finding parts is a chore. My components have been through so much wear and tear over countless years, too. #speaker:NiCo #mood:neutral
Being unable to upgrade to a newer model...
I'm metaphorically a slave to this body. #speaker:NiCo #mood:sad

(Oh, just <i>metaphorically</i> a slave, huh?) #speaker:Graciana #mood:think
In any case... #mood:neutral

*[How old are you...?]
    ->good2
*[Still a slave?!]
    ->chaos2
==chaos1==
~chaosN=chaosN+4
In terms of culture. #speaker:Graciana #mood:neutral
Well, culture in the sense of how the people are, I guess. #speaker:Graciana #mood:think
The average person in my world will work until they're like, senile. Still paying off loans, or a mortgage, or just taxes in general. #speaker:Graciana #mood:neutral
It's weird. We're conditioned to enjoy it, too. And anyone that breaks outside of that mold is considered the weird one... #speaker:Graciana #mood:think
Like, sorry I don't wanna work until I'm 80 just to survive, y'know? #speaker:Graciana #mood:angry

...
Working until you're 80? #speaker:NiCo #mood:neutral
80 what?

Uh... Years old? #speaker:Graciana #mood:think
(Right... I guess robots don't traditionally age?)

Oh, right, that makes sense. You still have an organic human body, so aging affects you a lot heavier that it would me. #speaker:NiCo #mood:smug
My internal parts still age, but that's more of a result of wear and usage. #speaker:NiCo #mood:neutral

Yeah, that makes sense... #speaker:Graciana
In any case, my point stands. Our worlds both encourage the people to work to the bone--or I guess metal.
Like, there's a weird amount of shame that you get from others if you aren't working as much as you physically can. I was scrubbing dishes at fourteen, in a crusty old pizzeria for six bucks an hour.
And I guess that made me a "hard worker" and "built character" or whatever, but...
I dunno, I just think it's weird.
And from what you've told me about MX-3319... It doesn't seem too far off, huh?

Yes, not too far off at all. #speaker:NiCo
You're put to work as soon as you're roboticized, no matter how "old" you are. #speaker:NiCo #mood:sad

...Do you guys not go to school or something? #speaker:Graciana #mood:think

No need. Any data we need is installed and fed to us virtually, and stored in our memory banks. #speaker:NiCo #mood:neutral
Of course, this means that most citizens are... well... #speaker:NiCo #mood:smug
Not the shiniest cut of steel, you get what I mean?
Most are essentially just on autopilot, not really knowing what to do with themselves outside of work. #speaker:NiCo #mood:neutral
But that's more of the newer gens. Us OG's have a bit more going on in our databanks than those newer models.
It's almost like Tundra makes them to have limited ambition or something. It wouldn't surprise me.

* [How old are you really...?]
    ->good2
    
* [Break free!]
    ->chaos2

==good2==
~affectionN=affectionN+4
Uh, NiCo, I don't mean to be rude or anything, but... #speaker:Graciana #mood:neutral

Go on, say it. #speaker:NiCo #mood:neutral

How... #speaker:Graciana
How old <i>are</i> you? #speaker:Graciana #mood:think

That's a fair question. #speaker:NiCo
Rude, but a fair question. #speaker:NiCo #mood:smug

...I'll take it. #speaker:Graciana #mood:neutral

When I was roboticized, I was about 22 years old. Tundra Enterprise already ran most things at that point, and were a big manufact #speaker:NiCo #mood:neutral
It had just recently come out that chemicals in the air were increasing at an alarming rate, and Tundra released their Roboticizing program plan.
I was already working for them at the time, so I was top priority in getting it--I was also one of the firsts to apply. #speaker:NiCo

Wait... #speaker:Graciana
You applied?! And were one of the firsts?! #speaker:Graciana #mood:fear
That goes against everything you've been complaining about!

Well, obviously we didn't have all the information at the time. #speaker:NiCo #mood:angry
I was still optimistic, too. I thought, "Oh, no way this corporation could offer me something bad! This is the future! They have my best interest at heart!"
... #speaker:NiCo #mood:neutral
And here we are now.

I getcha... #speaker:Graciana #mood:sad
How long ago was that...? #speaker:Graciana #mood:think

According to my date of assembly... #speaker:NiCo
Approximately 600 years, give or take.

600 years?! #speaker:Graciana #mood:fear

Give or take. #speaker:NiCo

So, you're 622 years old?! #speaker:Graciana

Give or take, yes. #speaker:NiCo

You've been working for Tundra... #speaker:Graciana #mood:think

Yes. #speaker:NiCo

...For like, 600 years... #speaker:Graciana

Correct. #speaker:NiCo

...And you're still in the same position, more or less... #speaker:Graciana
Still making barely any money, still struggling to get by, little to no benefits, every day a slog...

This is true. #speaker:NiCo

* [Still no new leg?!]
    ->good3
* [Dude, get outta there!]
    ->bad3

==good3==
~affectionN=affectionN+4
You would think that after working for that long, they'd give you some kind of reward, or at least respect... #speaker:Graciana
Or at least a new leg...

Yes... You would think, huh. #speaker:NiCo #mood:angry
But no. You don't get any sort of long-term benefits until you're employed for a thousand years. #speaker:NiCo #mood:neutral

You gotta slave away for a thousand years?! #speaker:Graciana #mood:fear
That's insane

... #speaker:NiCo
This really shouldn't be a shock at this point.

Yea, I guess... #speaker:Graciana #mood:sad

Although... #speaker:NiCo

Although? #speaker:Graciana #mood:think

I think I might have a lead. #speaker:NiCo #mood:happy

For...? #speaker:Graciana

The... "situation." With my leg. And the process of getting... Compensated. #speaker:NiCo

Oh! #speaker:Graciana #mood:neutral
That's awesome! What happened?

I talked to my friend who works in the mechanical & maintenance department. #speaker:NiCo

And? #speaker:Graciana

They said they can help me out. #speaker:NiCo
They have a few ideas on what could've possibly caused the malfunction.
None of which would have anything to do with me, too.
They just need more time to figure out the specifics.

That's awesome, NiCo! #speaker:Graciana #mood:happy

Yes, it's definitely some good news. I could use the vacation. #speaker:NiCo
Maybe I'll check out your Earth, Graciana.

Oh, trust me, I don't think it'd be that much of a change of scenery... #speaker:Graciana #mood:neutral

Well, in any case, I need to get back to my shift. #speaker:NiCo #mood:neutral

(They stand up from the booth and hobble over to the exit.) #speaker:Graciana

->ending

==bad3==
~affectionN=affectionN-3
Dude, what're you still doing? #speaker:Graciana
You gotta get outta there! #speaker:Graciana #mood:angry

And do what, exactly? #speaker:NiCo #mood:neutral
Tundra tracks me, so if I run away they would be shortly following.
Well, not like I could do much running, anyways.

R-right... #speaker:Graciana #mood:sad
Well, you could always--

No, I can't. #speaker:NiCo
I'm stuck like this for the rest of my life, until I inevitably break down.

H-hey now... #speaker:Graciana
You could always--

No, you don't get it! #speaker:NiCo #mood:angry

... #speaker:Graciana #mood:fear

All I do is work! #speaker:NiCo
Power on, go to work, power off!
Power on, go to work, power off. #speaker:NiCo #mood:neutral
Power on, go to work, power off... #speaker:NiCo #mood:sad

... #speaker:Graciana #mood:sad
I'm sorry, I didn't mean to make you upset...

... #speaker:NiCo
It's fine. #speaker:NiCo #mood:neutral
Excuse me.

(He gets up from the booth, and slowly hobbles toward the exit without a word.) #speaker:Graciana

->ending

==chaos2==
~chaosN=chaosN+4
Although... #speaker:Graciana
There is a key difference between our worlds.

Well, I can think of a handful of differences. #speaker:NiCo

Y-yeah, obviously, but I mean like, in terms of our worlds. #speaker:Graciana
Like how I said earlier, it's essentially the same, just that yours is a bit further along.

Yes, I can understand that comparison. What's your point, though? #speaker:NiCo #mood:smug

You have a chance to rebel against your world. #speaker:Graciana

... #speaker:NiCo #mood:neutral
Elaborate.

From what you've told me, it seems like the people of your world are essentially just slaves to a system, that they don't even realize they hate. #speaker:Graciana #mood:think
But there seems like there's a fair amount that's fed up with it, just like you. And they should be! #speaker:Graciana #mood:angry
You're created to serve! You're more or less being harvested for the sake of labor! It's like something out of a crazy Sci-Fi movie! #speaker:Graciana #mood:angry

...Sci-Fi movie? #speaker:NiCo #mood:smug

That's not my point! #speaker:Graciana #mood:angry
In my world, everyone is too scattered among themselves. We're still too hellbent on fighting each other, and not the actual problem. #speaker:Graciana #mood:think
And even then, it's not like we have one giant conglomerate "bad guy" to go against. No one would know where to start on Earth.
But on MX-3319, you have Tundra pulling the strings. And it seems like everyone knows that they run things, whether they think fondly of them or not.
I don't understand how you're not outraged to do something--All of the pieces are set up so perfectly! #speaker:Graciana #mood:angry

It's not that simple, Graciana. The system is ingrained in everyone. They're taught from the moment they're created that this is the right and correct way to exist. I can't undo centuries of conditioning on thousands of people overnight. #speaker:NiCo #mood:neutral

That's quitter talk! Are you just gonna lay down and take it? Gonna sit and stay like a good dog for the rest of your life? Or are you gonna bite the hand that hits you and break free?! #speaker:Graciana #mood:angry

... #speaker:NiCo #mood:smug

... #speaker:Graciana #mood:neutral
My metaphor might've fallen apart, but my point remains! #speaker:Graciana #mood:neutral

... #speaker:NiCo #mood:neutral
I understand what you mean.
It's hard to just... Do something like that.

Well, Rome wasn't built in a day. #speaker:Graciana

What's Rome? #speaker:NiCo

... #speaker:Graciana
I honestly don't know... Maybe like a building or something...? #speaker:Graciana #mood:think
It's just an old saying on Earth. It means that big changes like this obviously can't happen overnight. #speaker:Graciana #mood:neutral
It takes a little bit of patience, time, and effort. But it can be done.

... #speaker:NiCo
You know, Graciana, you have a particular way with words. #speaker:NiCo #mood:happy

What do you mean? #speaker:Graciana #mood:think

I'm not entirely sure myself, frankly. #speaker:NiCo
Your words... They always carry some sort of heavy weight with them.
I'm going to think over some things. You've given me a lot to think about.

(NiCo slinks out of the booth, and hobbles over to the exit.) #speaker:Graciana #mood:neutral

-> ending

==ending==
See ya, NiCo! #speaker:Graciana #mood:neutral

...
Yes. See you. #speaker:NiCo #mood:neutral

(NiCo exits the diner, and I clean up their table.)

//ensue trash minigame 2 dialogue

    -> DONE