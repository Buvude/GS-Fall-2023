INCLUDE globals.ink
EXTERNAL StartTTMicro()

... #speaker:NiCo #mood:neutral
Hi, Graciana.
*[What's up?]
->whatup
*[Sorry, nevermind.]
You should probably go help the customers who actually need to eat.
    ~GoToDiner()
    -> DONE
    
==whatup==
~convo_numberN=2
What's up? Would you like something to... #speaker:Graciana
...Eat? ...Drink? #speaker:Graciana #mood:think

... #speaker:NiCo #mood:smug

Sorry, I don't mean to be rude, uh... #speaker:Graciana
Can... can you... y'know...?

Not in the typical human way, no. #speaker:NiCo #mood:neutral
I have a chamber for processing food. It doesn't do anything to me energy-wise, but I can digitally process the taste and smell.
...Practicaly, it's useless. But I find it comforting.

Do you need to like... Recharge? Refuel? Something like that? I can siphon some gas out of the stove if you want? #speaker:Graciana

... #speaker:NiCo #mood:smug
I can fully charge electrically to 100% in approximately 20 minutes. #speaker:NiCo #mood:neutral

Oh wow, only 20 minutes? My phone takes like a whole hour to charge. #speaker:Graciana #mood:neutral
That's pretty efficient! #speaker:Graciana #mood:happy

Yeah. They make us efficient, so we can get back to working our twenty hour shifts. #speaker:NiCo

Twenty hours?! #speaker:Graciana #mood:fear
Isn't that against the law?!

It was. Until Tundra Enterprise changed it. They have money in the pockets of the lawmakers, too. #speaker:NiCo
Their point was that, "oh since you all can recharge so quickly, you can be more productive working happily!"
Ugh! #speaker:NiCo #mood:angry

I'm sorry... That sounds genuinely awful. #speaker:Graciana #mood:sad

On top of all of that, I'm heavily restricted with this leg injury #speaker:NiCo #mood:sad

Right, I was gonna ask about that... What happened there? #speaker:Graciana

Well, I was doing a delivery shift using one of their TundraTrucks. Done it thousands of times by now. #speaker:NiCo #mood:neutral
In order to operate one, you have to lock your leg into a chamber to activate the exhaust.

Like a gas pedal in a car? #speaker:Graciana #mood:think

Yes, very similar. But this locks your entire leg into place and plugs it in, so you can control it via your internal memory. #speaker:NiCo
Anyways, it malfunctioned on me, with my leg still in it. I'm not exactly sure what happened, I believe something short-circuited with the cheap materials they built it with.
As such, part of the internals combusted onto my leg and pieces of metal shrapneled into it, crippling me.

Oh, jeez... #speaker:Graciana #mood:neutral
Did you get any kind of compensation for that? #speaker:Graciana #mood:think

... #speaker:NiCo #mood:smug
Do you see how my leg is still damaged?

I guess that answers itself... #speaker:Graciana #mood:neutral
Can you really not get any kind of compensation for that? If it wasn't your fault and was instead fault of Tundra you should be entitled to some kind of worker's compensation!

That's what normal law would entail, yes. #speaker:NiCo
But this is MX-3319, a world ran by Tundra. While they smile and act as if nothing is wrong, they pull all the strings.
I don't think anyone has successfully gotten worker's compensation. It's infamously complicated and anti-worker. #speaker:NiCo #mood:sad

Did you at least try? #speaker:Graciana #mood:think

No. That's the equivalent of suicide. #speaker:NiCo #mood:neutral
Unless I can scientifically, statistically, and logistically prove that I was 100% not at fault, there is no way I can do anything about it.
And trying to fight them and failing is a death sentence.

... #speaker:Graciana #mood:neutral
Like, literally? Or... #speaker:Graciana #mood:think

I understand the assumption... But no, not literally. #speaker:NiCo #mood:smug
The last person that tried to fight Tundra for worker's compensation failed, and Tundra moved him over to the "waste management" field. #speaker:NiCo #mood:neutral
You dredge through the trash pit and process garbage for days on end, with an even higher risk of danger.
Legally, it's just a "movement of position." But that's where Tundra assigns anyone who tries to act against them.
We aren't stupid. We all know what Tundra is trying to do. #speaker:NiCo #mood:angry

So you either live with the hand you've been forcibly dealt, or try to struggle and end up worse off... #speaker:Graciana #mood:think

Yes. Some people think there's something that can be done still--That there's still hope for our world. But at this point, I just don't want to get scrapped. #speaker:NiCo #mood:sad

**[Is anyone doing anything?]
//good
~affectionN=affectionN+2

Is anyone doing anything about this? #speaker:Graciana #mood:think #sfx:gainedPoint

... #speaker:NiCo #mood:neutral
Doing what? There isn't anything to do. Tundra runs the world. It's impossible to "do" anything. #speaker:NiCo #mood:neutral

W-well yeah, but... #speaker:Graciana #mood:sad
Surely there's gotta be some sort of law that helps you guys, right? I mean, if they were able to change it. #speaker:Graciana #mood:neutral
Like, what's the legal system? Democracy? Republic? Autocracy? Monarchy...? #speaker:Graciana #mood:think
...Government isn't my forte, but I know some stuff...

Well, on paper the government calls itself a "Democratic Republic." #speaker:NiCo
Theoretically, we're supposed to be able to vote for representatives to make policies for us, things like that.
But with how hard Tundra has lobbied and bribed their way into the government... #speaker:NiCo #mood:sad
It's basically an Oligarchy now.

Ah, I see, well... #speaker:Graciana
...Hm...
(This... sounds kinda familiar...)

***[Representatives?]
...So, do you guys have like, representatives? Could you contact them to try to help? Or are those too being bribed? #speaker:Graciana #mood:think

Unfortunately, yes. #speaker:NiCo #mood:sad
Tundra has their money in the pockets of every part of our government.
It's more of Tundra's government, rather than our government's government
Our representatives, our leaders, our president...
All the decisions they make are based on whether or not Tundra finds it acceptable, and it doesn't hurt their business.

****[Drop it]
->dropped

****[Evidence for your injury?]
->injury

***[Evidence for your injury?]
->injury

(...Jeez, this really does sound familiar...) #speaker:Graciana

**[Just move!]
//chaos
~chaosN=chaosN+2

Why don't you just... get outta there? Like move out? If you can travel interdimentionally, surely you can just move, right? #speaker:Graciana #mood:think #sfx:cosmicPoint

God, I wish it were that simple. #speaker:NiCo #mood:smug
We can only travel for a little bit at a time. And they keep tabs on our location. They'd track us down, fast. #speaker:NiCo #mood:neutral

How do they keep tabs? Just go really really far away! #speaker:Graciana #mood:happy

... #speaker:NiCo #mood:smug
They made us. Our bodies have trackers built into them. No matter what, there isn't anything we can do about it. They can shut us down remotely whenever they want, too.

S-shut you down? #speaker:Graciana #mood:fear

Yes. #speaker:NiCo #mood:neutral
They can control us directly from their headquarters. If the algorithm detects that we are misbehaving, they'll override us directly.

Oh... Well... You could... Uh... Get... rid of them...? #speaker:Graciana #mood:think

... #speaker:NiCo #mood:smug
The algorithm? I mean. Hm... #speaker:NiCo #mood:neutral
It isn't impossible... There have been rumors of someone able to do that...

O-oh, like, actually? #speaker:Graciana #mood:neutral

Yes, I've heard of it before... #speaker:NiCo
But I shouldn't talk about it outloud. Tundra would take notice.

Right, they can probably hear you too... #speaker:Graciana #mood:think
Jeez, that's terrifying. When do you get any privacy? #speaker:Graciana #mood:neutral

No. #speaker:NiCo #mood:smug

Like, no as in-- #speaker:Graciana

No as in we don't ever get any privacy. We are monitored 24/7. #speaker:NiCo #mood:neutral

Like, even at home? When you aren't working? #speaker:Graciana #mood:think

That's what 24/7 means, yes? #speaker:NiCo #mood:smug

R-right, yeah... #speaker:Graciana #mood:sad
Well, regardless, I think you should look into that person you mentioned earlier--the person that can hack that algorithm.
And, uh, see if you can, uh... #speaker:Graciana #mood:neutral
Report them... *(wink wink)* #speaker:Graciana #mood:happy

... #speaker:NiCo #mood:smug
Why would I want to report them?

...That's... Uh... #speaker:Graciana #mood:sad

***[Be more obvious]
//bad
~affectionN=affectionN-1

I mean like, y'know, uh... #speaker:Graciana #mood:neutral #sfx:lostPoint
See if you can like, get them to, uh, take a look at you? #speaker:Graciana #mood:think

... #speaker:NiCo

To like, y'know, see if he can hack you? #speaker:Graciana
To maybe... Make it so they aren't listening...?

... #speaker:NiCo
You are suggesting that I violate Tundra Enterprise Terms of Service? #speaker:NiCo #mood:ad

W-wait, uh, n-no, I didn't mean to-- #speaker:Graciana #mood:fear

Voice signature identified. #speaker:NiCo

V-voice signature?! #speaker:Graciana

You, [GRACIANA], have been registered in the Tundra Enterprise Customer Database as a violator of the Terms of Service. #speaker:NiCo
You have been stricken from use of Tundra Enterprise products, devices, and transportation for an indefinite period of time.
Please contact your local Tundra Kiosk for further information.

U-uh, I don't know if I--

<i>(BZZZZZZZZZZZZT)</i> #speaker:NiCo
...

... #speaker:Graciana #mood:sad

...#speaker:NiCo #mood:smug
Do you not remember when I just said that they listen in, and can detect misbehavior?

Right, uh... S-sorry about that... #speaker:Graciana
I hope I didn't get you in any trouble...

No, I should be fine since I didn't say anything wrong. #speaker:NiCo
You, on the other hand, should probably not go to MX-3319 any time soon.

Am I gonna get like, arrested? #speaker:Graciana
Are they gonna put me on garbage duty?! #speaker:Graciana #mood:fear

No, nothing like that. You don't live in MX-3319, so they can't do anything like that. #speaker:NiCo
You're just restricted from doing... Well, basically anything.

Oh... #speaker:Graciana #mood:sad
Well, it's not like I wanted to go to there anyways--No offense. #speaker:Graciana #mood:neutral

Trust me, I'm not at all offended. #speaker:NiCo #mood:neutral

This happen before? #speaker:Graciana #mood:think

Yes, a few times. #speaker:NiCo
Like I said, Tundra is always listening. They have an algorithm that detects what we and others around us say.

(There's gotta be *something* they can do...) #speaker:Graciana

****[Evidence for your injury?]
->injury
****[Strike!]
->strike

***[Try to insinuate]
//good
~affectionN=affectionN+2

Hm... #speaker:Graciana #mood:think #sfx:gainedPoint
I mean... You could try to see if there's a way for you to learn more about this hacking process that seems to be going around.

... #speaker:NiCo #mood:smug

Like, uh... #speaker:Graciana #mood:sad
Gather all the information you can about it. So you can *definitely* try to avoid that person. <i>(wink wink)</i> #speaker:Graciana #mood:happy
In fact, you might want to go to where they are, just so you can be fully sure of where they are so you can avoid it. <i>(wink wink)</i> 

... #speaker:NiCo #mood:neutral
Avoid it...? But isn't that counterintuitive to what I was talking about? 
Unless...

Unless... <i>(wink wink)</i> #speaker:Graciana

... #speaker:NiCo
Ah...... #speaker:NiCo #mood:happy
I think I understand what you mean...
I should learn about the person that can hack into the listening algorithm... So I can "avoid" them...

Yeah, exactly! #speaker:Graciana #mood:happy
Maybe even talk to that person and see if you can find out how they do it, so you can maybe...
"Report" it...

... #speaker:NiCo
And whatever I do, I shouldn't let them take a look at me, or let them hack into me, right?

R-right, yeah, definitely don't let them do that! <i>(wink wink)</i>#speaker:Graciana 

Got it. I think I already have a few ideas on what to do... #speaker:NiCo #mood:neutral
Thanks, Graciana. #speaker:NiCo #mood:happy

Anytime at all. #speaker:Graciana #mood:happy
...
(Surely there's even more that they can do, right...?) #speaker:Graciana #mood:think

****[Evidence for your injury?]
-> injury
****[Strike!]
->strike
==strike==
//chaos
~chaosN=chaosN+2

What about, uh... #speaker:Graciana #mood:think #sfx:cosmicPoint
(Hm, I gotta be careful about how I word this...)
What if...
You, and a few other workers got together and... Maybe... #speaker:Graciana #mood:neutral
Made a list of, expectations that you wish Tundra could provide you with...? #speaker:Graciana #mood:think

... #speaker:NiCo #mood:smug
What, like a Christmas List? Tundra doesn't provide us with anything like that. We work through holidays. #speaker:NiCo #mood:neutral

No, not like that... Like, a list of, I guess... Demands? #speaker:Graciana #mood:sad

Demands? #speaker:NiCo #mood:smug
Hah! That's a good one! #speaker:NiCo #mood:happy
As if Tundra would ever consider that at all! #speaker:NiCo #mood:angry

W-well, maybe, but... #speaker:Graciana #mood:sad
If you get a lot of other workers--maybe even some from other departments... #speaker:Graciana #mood:think
You can all collectively organize and demand this together! #speaker:Graciana #mood:happy

... #speaker:NiCo #mood:smug
And what difference would that make?

If you all organize... #speaker:Graciana #mood:think
You can threaten to not work until your demands are met! #speaker:Graciana #mood:happy

... #speaker:NiCo #mood:smug
There's no way that'll work.

Why not?! #speaker:Graciana #mood:angry

There's no way everyone would agree to that. #speaker:NiCo #mood:neutral
A lot of us recognize how bad Tundra is. But there's even more that worship them, and are none the wiser to everything they do. 
They don't know any better. They don't realize Tundra is slowly killing us. #speaker:NiCo #mood:sad

Well... #speaker:Graciana #mood:think
Tell them! Make it known! #speaker:Graciana #mood:angry
Start by organizing with those that are on your side. And then work your way to the others that don't know of what Tundra's done.
Word of mouth, posters, the internet... #speaker:Graciana #mood:think
There are so many ways to do this! You can't just give up like that! #speaker:Graciana #mood:angry

... #speaker:NiCo #mood:smug
I guess a lot of the people in my department have been a bit on edge lately due to Tundra's new break policy. #speaker:NiCo #mood:neutral

There you go! #speaker:Graciana #mood:happy
Strike while the iron is hot!

... #speaker:NiCo #mood:smug
We're primarily made from nickel, not iron.
And why would I strike my coworkers? Wouldn't that be counterproductive to my cause?

... #speaker:Graciana #mood:sad
It's a saying... 
Nevermind, ignore that. Just focus on organizing and getting them on your side. #speaker:Graciana #mood:neutral

This actually seems plausible. #speaker:NiCo #mood:happy
A very slim chance of success, but plausible.
You've given me a lot to think about. Thank you.

Good! I'm glad I could help. #speaker:Graciana #mood:happy
->wrapitup

==dropped==
//bad
~affectionN=affectionN-1

Alright, alright, maybe you have a point, but still... #speaker:Graciana #mood:sad #sfx:lostPoint

Told you, there really isn't much any of us can do about anything on MX-3319. #speaker:NiCo #mood:neutral
We're all just the cogs of their machine. #speaker:NiCo #mood:sad
...
There's a pun in that somewhere, but I don't have the energy to process it. #speaker:NiCo #mood:smug

R-right... #speaker:Graciana #mood:sad
I honestly have no idea how you do it. How you manage to live there and work every day, despite what's going on there. #speaker:Graciana #mood:neutral

... #speaker:NiCo #mood:neutral
What choice do I have? #speaker:NiCo #mood:sad

*****[It is what it is...]
//bad
~affectionN=affectionN-1

I mean... Jeez, that's really rough. #speaker:Graciana #mood:sad #sfx:lostPoint

Yes. It is. #speaker:NiCo #mood:sad

I guess... It is what it is, huh? #speaker:Graciana
Like how much can you really do there? Do they just control everything there? #speaker:Graciana #mood:think

Yes, more or less. #speaker:NiCo #mood:neutral
They control where we live, they control what we buy, what we look like, they own where we go... #speaker:NiCo #mood:sad
Well, not on paper at least. But there's no other option. They have a full monopoly on essentially every type of market and service that exists. #speaker:NiCo #mood:neutral
If someone tries to insinuate breaking the rules, they can get restricted, and lose access to essentially everything. #speaker:NiCo #mood:sad

Could you use some kind of alternative? Like, a different service? #speaker:Graciana #mood:think

There is no alternative. Tundra eliminated any competition. #speaker:NiCo #mood:neutral

Oh, right, yeah... Monopoly and all that. #speaker:Graciana #mood:sad
Uh... Jeez, yeah I have no idea dude. How do you do like, anything? Like, what's an average day? #speaker:Graciana #mood:sad

Well, we wake up in our tiny pod apartments in the TundraPlex. #speaker:NiCo 

TundraPlex? #speaker:Graciana #mood:think

The residential unit. Holds thousands of us in tiny closet-sized "apartments." #speaker:NiCo
We at least get to decorate them... With Tundra products and Tundra furniture... #speaker:NiCo #mood:sad
But anyways, we go to our shift early in the day. It depends where you're stationed--I typically work in the warehouse. #speaker:NiCo #mood:neutral
I work for twenty hours every day, with a thirty minute break in the middle.

...Are you on break right now? I just assumed you had the day off. #speaker:Graciana

Yes, I'm on break right now. I just like to come here for a little bit--change of scenery. #speaker:NiCo
The one decent thing Tundra has done is make interdimentional travel quick and easy.
...Of course, they track where we go, and we're only allowed to go to certain verified locations... #speaker:NiCo #mood:sad
But, that could be worse, I suppose. Still doesn't make up for everything else, but still.

Yeah, I still can't believe you have to work a twenty hour shift. With only a thirty minute break?! #speaker:Graciana #mood:angry

Our bodies are made to be twice as efficient as a human body. Therefore, they make us work twice as much as a human body. #speaker:NiCo #mood:sad

Still, that's so much time though... #speaker:Graciana #mood:think
You basically only get 4 hours a day to yourself! #speaker:Graciana #mood:angry
And even then, it's not really "to yourself" since you're being monitored.

Preaching to the choir, Graciana. #speaker:NiCo #mood:angry
Most people are too desensitized to the system to realize there's anything wrong with it.
And I can't blame them. It's not like we have a choice for anything different. #speaker:NiCo #mood:neutral

(Why does this kinda sound like... Familiar?)
->wrapitup

*****[Strike!]
->strike

==injury==
//good
~affectionN=affectionN+2

So, going back to what you said earlier, about how hard it is to fight Tundra in court... #speaker:Graciana #sfx:gainedPoint
I know it's intimidating, but do you have like, any evidence in your favor? Doesn't matter how big or small it is. #speaker:Graciana #mood:think

Well, there is the security footage... #speaker:NiCo #mood:smug

That's huge! #speaker:Graciana #mood:happy
Wouldn't that prove that you didn't do anything wrong?

You would think so, but that alone isn't enough. #speaker:NiCo #mood:sad
Tundra would say that it's possible that there was an "internal error" on my part. #speaker:NiCo #mood:neutral

Internal error? Like, your "code" messed with the machine? #speaker:Graciana #mood:think

Something like that, yes. #speaker:NiCo 

...Didn't Tundra make your code, though? #speaker:Graciana
Wouldn't that also be their fault, making you eligible for compensation?

Possibly, but it's too unpredictable. #speaker:NiCo
They could blame it on me in a variety of ways--I wasn't on the latest update, I downloaded an unauthorized program, my battery needed to be replaced... #speaker:NiCo #mood:sad
I appreciate your concern, Graciana, but I really don't think it's possible.

*[Keep pushing]
//good
~affectionN=affectionN+2

Nope, there's gotta be a way! #speaker:Graciana #mood:happy #sfx:gainedPoint
What about the machine itself? You mentioned that it was made with cheap materials. The machine might've been at fault! #speaker:Graciana #mood:angry

The TundraTrucks, yes. They're cheaply mass produced meant to transport bulk materials and packages. #speaker:NiCo #mood:angry
Unfortunately, the TundraTrunk was scrapped shortly after the malfunction, so there's no way for me to check. 
I know someone in the maintenance department, they might know what could've caused the TundraTruck to malfunction. But... #speaker:NiCo #mood:neutral

But...? #speaker:Graciana #mood:think

They would never tell me. #speaker:NiCo #mood:sad

What? Why not?! #speaker:Graciana #mood:angry

Well, they, and I, uh... #speaker:NiCo #mood:neutral
Aren't, on the best of terms. #speaker:NiCo #mood:sad

What happened? You broke their heart or something? #speaker:Graciana #mood:happy

No! It's not like that. #speaker:NiCo #mood:angry
We got into an argument about, uh... #speaker:NiCo #mood:neutral
Something completely unrelated. It's irrelevant! #speaker:NiCo #mood:angry

Right... Well, do you think it would be possible to put those feelings aside for a brief moment? For the sake of your health? #speaker:Graciana #mood:think

...
I'll think about it. #speaker:NiCo #mood:happy

Did you like, insult them or something? #speaker:Graciana

Rude of you to assume I was the one at fault! #speaker:NiCo #mood:angry

Well... were you? #speaker:Graciana

... #speaker:NiCo #mood:smug
It's possible.

Well, an apology might be a good start, don't you think? #speaker:Graciana #mood:happy

Maybe. I'll think about it. #speaker:NiCo 

I'll take it. #speaker:Graciana
Would they be willing to help you with this, if you apologized & everything? #speaker:Graciana #mood:think

Even if I did, I'm not entirely sure... #speaker:NiCo #mood:sad
Yes, a lot of us acknowledge and are aware of the damage Tundra has done. #speaker:NiCo #mood:neutral
But at the same time, there are a lot more people that are none the wiser, and just sort of accept how our world is. They don't know any better. #speaker:NiCo #mood:sad

I see... #speaker:Graciana #mood:think
Is your friend one of these people?

Yes, exactly. #speaker:NiCo #mood:angry
It'll be hard to convince them to do... Well, anything really. #speaker:NiCo #mood:sad
They would know what's wrong with the TundraTruck almost immediately. They know all the common errors and faults that could possibly occur.
Again, the problem is getting imperical evidence of that, but...

But...? #speaker:Graciana #mood:think

But it isn't impossible. #speaker:NiCo #mood:happy
Thank you, Graciana. I think I have an idea of what to do now.

Of course, any time! #speaker:Graciana #mood:happy
->wrapitup

*[Drop it]
->dropped



    
==wrapitup==
... #speaker:NiCo #mood:neutral
Well, I need to get back to my shift.
Thank you for chatting with me, Graciana.

Of course. Hope you come back soon! #speaker:Graciana #mood:happy
(He shambles his way out of the booth, and limps over through the entrance portal.)
...
...Alright, I think that should do it. #speaker:Graciana #mood:neutral
~currentConvo="NMG1"
~timeOfDay="afternoon"
~TTMLevel=2
~QuickSave()
~StartTTMicro()
//trash minigame will go here. i'm not sure if putting in cece out of nowhere will break the game, so i'm leaving it like this for now once that's fully implemented
-> DONE