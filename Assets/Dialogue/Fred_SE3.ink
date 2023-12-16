INCLUDE globals.ink

(Fred is excitedly waving me down...) #speaker:Graciana #mood:neutral

* [Hey Fred!]
    ->Start
* [(Leave him be)]
Sorry Fred, I'll be back in a minute! #speaker:Graciana #mood:neutral
~GoToDiner()
    -> DONE

==Start==
~convo_numberF=4
Fred! My favorite little star, how are you? #speaker:Graciana #mood:neutral
How did it go with Frank! What did you do? Tell me everything! #speaker:Graciana #mood:happy

... #speaker:Fred #mood:neutral
You seem to be more excited about this than me...

Well, I gave you advice, and I wanna know how it panned out! #speaker:Graciana #mood:happy
And as your friend, I am heavily invested in what happens to you!

Aww... #speaker:Fred #mood:sad
I was gonna make a joke but that's actualy just really nice! #speaker:Fred #mood:galaxy

Let me get you a smoothie, and you prep your story! #speaker:Graciana #mood:neutral #scg:black
//blackout scene i dont remember what the tag is rn  it's like 1am i promise ill do it soon ;-;

Alrighty, there you go! Now dish what happened! #speaker:Graciana #mood:happy #ecg:

Well I don't really know where to start... #speaker:Fred #mood:neutral
We went and watched the shows you recommended after work! #speaker:Fred #mood:happy

And did he like them? #speaker:Graciana #mood:think

Yeah! He talked a lot about stuff I didn't really understand... #speaker:Fred #mood:neutral
But I think he liked them! #speaker:Fred #mood:happy

That's awesome, Fred! And did you talk about school and the suit, or the whole adoption situation?  #speaker:Graciana #mood:neutral

Well... #speaker:Fred #mood:sad
 
Did you? #speaker:Graciana #mood:neutral

I was scared to... #speaker:Fred #mood:sad
Whenever I bring it up he goes quiet, and I don't know what to do.
He seemed to be enjoying himself and talking about the characters he liked when he was growing up though #speaker:Fred #mood:neutral
I didn't want to ruin it... #speaker:Fred #mood:sad

(Damn, I don't know whether to praise the observation, or critize him avoiding the conversation...) #speaker:Graciana #mood:think
// Ending Divert goes here
{
-chaosF>=chaosTotalF:
    ->FredChaosEnd
-affectionF>=0:
    ->FredGoodEnd
-else:
    ->FredBadEnd
}

==FredGoodEnd==
That's actually really thoughtful of you, Fred! #speaker:Graciana #mood:happy

I love that you care about Frank so much, but if you're gonna move forward in your life you need to do it, right? #speaker:Graciana #mood:neutral

If he says yes, you could instantly have a Dad who cares very deeply about you and who is willing and parently obiligated to help you with your situation. #speaker:Graciana #mood:neutral

Giving him the benefit of the doubt, not knowing about your situation and caring enough to work basically 20 hours a day to help you... #speaker:Graciana #mood:think
I think he could be a really great parent.  #speaker:Graciana #mood:neutral
What do you think? #speaker:Graciana #mood:neutral

I think you're right! #speaker:Fred #mood:happy
He's really nice, and we like a lot of the same stuff too! #speaker:Fred #mood:pump

Exactly! And think about it, he gets paid. #speaker:Graciana #mood:neutral
So long as he's somewhat responsible with his money, he should be able to pay for you to go to school.
And you can make friends your own age! #speaker:Graciana #mood:happy

I haven't really thought about that... #speaker:Fred #mood:neutral

Well, now's the time to, bud! #speaker:Graciana #mood:happy

What do you do think? What would <i>you</i> wanna do first? #speaker:Fred #mood:galaxy

*[Work at UMS with Frank]
 
I think it would be nice to work with Frank more. #speaker:Graciana #mood:think
As long as you don't have to work to pay off the suit, that is. #speaker:Graciana #mood:neutral

I think I understand that's a bad thing now... #speaker:Fred #mood:neutral

Damn right it is, little star. #speaker:Graciana #mood:happy
Never let them take advantage of you again! Especially now with Frank in your corner, you should be untouchable by those corporate bastards!

You called them "bastards" a few times now... What does that mean? #speaker:Fred #mood:neutral

Shit... #speaker:Graciana #mood:neutral

Shit? #speaker:Fred #mood:neutral

Learn from Frank, not me when it comes to words, hun. #speaker:Graciana #mood:think
I have... "Earth Syndrome." #speaker:Graciana #mood:neutral
Our language hasn't evolved to be understanding of others in hundreds of years... #speaker:Graciana #mood:think
So don't repeat the words I say. #speaker:Graciana #mood:neutral

Oh. #speaker:Fred #mood:neutral

Oh indeed. #speaker:Graciana #mood:neutral

Okay, so I should keep working with Frank as long as I get money for it? #speaker:Fred #mood:neutral
And then what?
->GoodFinal
*[Go to school]

You could always to school! #speaker:Graciana #mood:happy

Is school really worth it? #speaker:Fred #mood:neutral
A lot of my coworkers never went to school, but they got jobs anyways... #speaker:Fred #mood:neutral

Well, it's not needed for UMS jobs... #speaker:Graciana #mood:think

BUT! It's still important you go for the social aspect! #speaker:Graciana #mood:ha

You can make friends, talk to people of all different cultures, planets, realms, planes of existence, and even other dimensions! #speaker:Graciana #mood:neutral
Plus, you can learn about anything you want! If you want to learn more about stars you can do that! You can even learn about history, languages, math, though that's not really fun for most people, anything you want to at all! #speaker:Graciana #mood:neutral

Hm... #speaker:Fred #mood:neutral
Okay! If you think it's the right thing to do, I don't see why not! #speaker:Fred #mood:neutral

Well, you can also ask Frank about it and he'll agree with me, I'm 99% sure! #speaker:Graciana #mood:happy

What's the 1% for? #speaker:Fred #mood:neutral

Don't worry about it, it's just a saying. #speaker:Graciana #mood:neutral

But isn't that math? I thought you didn't like math? #speaker:Fred #mood:neutral

... #speaker:Graciana #mood:neutral

You are going to make some poor underpaid teacher's day with all these questions. #speaker:Graciana #mood:happy

I am? #speaker:Fred #mood:happy

Of course, little star. #speaker:Graciana #mood:neutral

Okay! So once I go to school, what do I do after that? #speaker:Fred #mood:neutral
->GoodFinal
*[Be a kid!]

Be a kid for once! #speaker:Graciana #mood:happy

I don't get it... #speaker:Fred #mood:neutral

Fred, you've been working for hundreds of years! #speaker:Graciana #mood:neutral

...? #speaker:Fred #mood:neutral
 
Most kids don't work 'til they're older, or have had some sort of education or learned a trade. #speaker:Graciana #mood:neutral

Okay... #speaker:Fred #mood:neutral

And think about it... #speaker:Graciana #mood:think
You could do whatever you want for a few years, to relax after working for a suit you should have paid off hundreds of years ago! #speaker:Graciana #mood:happy

I think I'm following you... #speaker:Fred #mood:happy

You could watch cartoons, play with other kids, go out and talk with people whenever you want, eat whatever you want, go wherever you want... #speaker:Graciana #mood:think
Really, just have fun! #speaker:Graciana #mood:happy

That's a lot... #speaker:Fred #mood:sad

It very much is Fred! You missed out on a lot of kid shenanigans--Might not be a bad idea to enjoy life with Frank for a little bit! #speaker:Graciana #mood:neutral
Earth has some great Theme parks and carnivals you could go to! #speaker:Graciana #mood:happy

What are those? #speaker:Fred #mood:neutral
//...carnivals Fred asks what they are, and Graciana starts describing roller coasters
Massive thruster propelled carts that shoot you around the sky, using only small metal railings to keep you in place on a winding track... #speaker:Graciana #mood:neutral

Oh...
That kinda sounds scary, not fun #speaker:Fred #mood:neutral
 
Well it is in concept, but it's actually really fun when you try it! 
Some even go to the moon and back! #speaker:Graciana #mood:neutral

Oh, that does sound fun! #speaker:Fred #mood:Happy

See! And you and Frank could bond over all that, and make some really nice memories! #speaker:Graciana #mood:happy

Hmm... #speaker:Fred #mood:neutral

You seem to think it's fun, so I think it will be, too! #speaker:Fred #mood:happy

(I feel like a proud teacher whose student is graduating...) #speaker:Graciana #mood:happy

But after all the coasters and parks, what do I after? #speaker:Fred #mood:neutral
School, Work, just having fun forever? #speaker:Fred #mood:neutral

->GoodFinal
==FredChaosEnd==
Well, when are you planning on asking him? #speaker:Graciana #mood:think

I don't know. #speaker:Fred #mood:neutral

Well, do you still want to ask him? #speaker:Graciana #mood:think
 
I don't know... #speaker:Fred #mood:neutral

Oh boy, what changed? #speaker:Graciana #mood:think

I don't know... #speaker:Fred #mood:sad
 
You're worrying me my little clueless star... Speak in more than three words please... #speaker:Graciana #mood:neutral

Well, I had fun with him, right? #speaker:Fred #mood:neutral

Yes? I feel a "but" coming after that... #speaker:Graciana #mood:think

But what you said earlier got me thinking... #speaker:Fred #mood:neutral

About? #speaker:Graciana #mood:think

Well, do you remember what you first said me to when I mentioned Frank worked with me before? #speaker:Fred #mood:neutral

*[How long you two worked...] 

How long you had worked with each other? #speaker:Graciana #mood:think

Right!#speaker:Fred #mood:happy
And I thought about it a little... #speaker:Fred #mood:neutral

What about it, hun? #speaker:Graciana #mood:neutral

He's nice to me at work... #speaker:Fred #mood:neutral
And he's been nice for a while. #speaker:Fred #mood:neutral

Mhm, and? #speaker:Graciana #mood:think

Well, that's it. #speaker:Fred #mood:neutral
It's been a while that he's been doing this...

And that brings us to...? #speaker:Graciana #mood:think

He hasn't tried to help outside of being nice to me for hundreds of years... #speaker:Fred #mood:sad
Hasn't even brought up UMS using me once... #speaker:Fred #mood:sad

Oh... right... #speaker:Graciana #mood:sad

But there was one person that did, as soon as they heard about it happening... #speaker:Fred #mood:neutral
Oh...? #speaker:Graciana #mood:think

... #speaker:Fred #mood:neutral

(He's staring at me...) #speaker:Graciana #mood:think

->ChaosFinal
*[How much you trust Frank?]

How much you trusted Frank? #speaker:Graciana #mood:think

No, silly, the other one! #speaker:Fred #mood:happy

Hey, I talk a lot, it could be just about anything! #speaker:Graciana #mood:neutral

What you said about him working with me...? #speaker:Fred #mood:neutral

Mhm, I'm following. #speaker:Graciana #mood:neutral

When you asked me how old I was ? #speaker:Fred #mood:neutral

Mhm, I certaintly did ask that. #speaker:Graciana #mood:think

You also asked how old he was? #speaker:Fred #mood:neutral

Sounds like a reasonable question for me to ask, your honor. #speaker:Graciana #mood:think

You asked how long we knew each other? #speaker:Fred #mood:neutral

Mhm, good follow up by me... #speaker:Graciana #mood:think

And during that time, how long we knew of each other? #speaker:Fred #mood:neutral

I seem to be quite thorough... #speaker:Graciana #mood:think

I don't know what that means... #speaker:Fred #mood:sad

Persistent? #speaker:Graciana #mood:think

Nope. #speaker:Fred #mood:neutral

Keeping questioning stuff 'til it makes sense. #speaker:Graciana #mood:neutral

Ah...? #speaker:Fred #mood:neutral

Ah, indeed. #speaker:Graciana #mood:neutral
Well yes, "Miss Thorough," you mentioned we worked together for a long time? #speaker:Fred #mood:neutral
Mhm, I did #speaker:Graciana #mood:neutral

And he had all that time to try and get closer with me if he wanted to...? #speaker:Fred #mood:neutral

That he did. #speaker:Graciana #mood:neutral

But he didn't? #speaker:Fred #mood:neutral

That, he did not. #speaker:Graciana #mood:neutral

You are being really smart today! #speaker:Fred #mood:galaxy

Why thank you, my good star sir! #speaker:Graciana #mood:happy

Other meaning of smart? #speaker:Fred #mood:Happy

Ha, someone's picked up a little sass, have we? #speaker:Graciana #mood:happy

Wonder where I got it from...? #speaker:Fred #mood:happy

Oh no, I'm a problem it seems! #speaker:Graciana #mood:happy

That we agree? #speaker:Fred #mood:neutral

And your point is, smarty suit pants? #speaker:Graciana #mood:think

Only one sassy person has tried to help me out of this... #speaker:Fred #mood:neutral

->ChaosFinal
*[Franks favorite shows?]
What Franks favorite shows were? #speaker:Graciana #mood:think

No! Before that! #speaker:Fred #mood:angry

Uhhh... #speaker:Graciana #mood:think
What he was?

No! #speaker:Fred

What his favorite color was? #speaker:Graciana

You're not even trying! #speaker:Fred

Help a gal out here, little star. #speaker:Graciana #mood:neutral

Time! #speaker:Fred

Ah time, it <i>is</i> a weird soup. #speaker:Graciana #mood:neutral

Yes, you said that, but Frank's time at UMS. #speaker:Fred #mood:neutral
It's just as long if not longer than mine... #speaker:Fred #mood:sad
but he said nothing during that time #speaker:Fred #mood:neutral

Nothing about me, nothing about the suit--He just helped me learn how to do things by myself.  #speaker:Fred #mood:neutral

Okay, I see now. And this brings us to you feeling bad about Frank? #speaker:Graciana #mood:think

No! of course not! #speaker:Fred #mood:angry
I still really care what he has done for me... #speaker:Fred #mood:sad
But he didn't try and fix anything, just make it more bearable. #speaker:Fred #mood:neutral
Ah... #speaker:Graciana #mood:think
Only one person really tried to change my life... #speaker:Fred #mood:neutral
Oh? and who's that? #speaker:Graciana #mood:think

... #speaker:Fred #mood:neutral 
->ChaosFinal
 
==FredBadEnd==

Fred... #speaker:Graciana #mood:sad
Even if he says no, it's better knowing.
Just remember, even if he ends up being a dead end for adoption, it's still better to ask now versus later, so you can find someone to help you sooner than later. #speaker:Graciana #mood:neutral
And that way you aren't stuck working at UMS for another hundred years, getting paid nothing for wearing a suit that does nothing. #speaker:Graciana #mood:angry

I mean yeah, but I don't know... #speaker:Fred #mood:sad

Everything you've been saying has kinda been making sense... #speaker:Fred #mood:neutral
Kinda...

Oh? And that was? #speaker:Graciana #mood:think

The work thing, UMS is sadly my life right now... #speaker:Fred #mood:sad
And I'm not sure I want that. #speaker:Fred #mood:sad
Frank is great... #speaker:Fred #mood:neutral
But I don't know if he's worth spending all my time working at UMS. #speaker:Fred #mood:sad
Does that make sense? #speaker:Fred #mood:neutral

Of course! #speaker:Graciana #mood:neutral

And remember what I said a few days ago, you have other options for people that care for you, and it's better to leave UMS and that whole suit business behind anyways! #speaker:Graciana #mood:happy
Nothing good will come from working for a corporation that doesn't value you as a person. #speaker:Graciana #mood:angry
But speaking of caring for you, did find out more about the two mysterious people you mentioned before? #speaker:Graciana #mood:think

Yeah... #speaker:Fred #mood:neutral
I don't know if they like me enough to adopt me. #speaker:Fred #mood:sad
But I know I don't want to work at UMS for much longer! #speaker:Fred #mood:angry
The more you talk about them using me, the more I notice things they say at work are bad!

And you're right, this suit isn't my world. #speaker:Fred #mood:angry
I can live without it!
Even if it <i>is</i> fun to wear, I can get another one, right?!

Of course! #speaker:Graciana #mood:happy

What do you think it should be? #speaker:Fred #mood:neutral

The new suit? #speaker:Graciana #mood:think

Yeah! #speaker:Fred #mood:happy

Hmmm, let me think... #speaker:Graciana #mood:think

->BadEnding
==GoodFinal==

After you're done with everything you want, I'll always be here for bits of amazing life changing advice, and Frank will be there to take care of you! #speaker:Graciana #mood:happy

Don't worry about your entire future now! Enjoy the present and do whatever you think is best, even if you choose wrong, you will have thousands of chances to choose right in your life, little star. #speaker:Graciana #mood:neutral

That sounds like a lot... #speaker:Fred #mood:neutral

It is! #speaker:Graciana #mood:neutral

And what happens if I don't have enough time to visit, or if Frank takes me somewhere else? #speaker:Fred #mood:sad

Well Fred, here at O'Ryan's Diner we have a saying, do you know what that is? #speaker:Graciana #mood:think

Nope! #speaker:Fred #mood:pump
 
No matter where you are or what you desire, we are just a wormhole away! #speaker:Graciana #mood:happy
 
Oh... #speaker:Fred #mood:happy

Thanks Graciana! I think I had a lot of fun talking to you! #speaker:Fred #mood:pump
Wait no, with you! #speaker:Fred #mood:happy

(I'm  gonna start tearing up here...) #speaker:Graciana #mood:neutral
 
Me too, little star. Make sure you visit every so often to keep me up to date on how you're doing, alright? #speaker:Graciana #mood:neutral

Alright! #speaker:Fred #mood:happy

Well I have to go tell Frank the good news, and ask him a very important question! #speaker:Fred #mood:happy

Bye! #speaker:Fred #mood:pump

(Fred gives me a quick hug before running off towards the portal, and diving head first into the swirling vortex that leads to UMS headquarters) #speaker:Graciana #mood:neutral

Shit I'm going to miss that kid #speaker:Graciana #mood:neutral

(Stares off into the distance as a Ums ship soars past the diner in the distance) #speaker:Graciana #mood:neutral

I'm really going to miss that little star #speaker:Graciana #mood:neutral
(a few months go by before a tall lanky figure in a Ums uniform comes in asking for you by name)
(his presence is somewhat mysterious and you feel certain there is something strange about him)

(But he carries a gentle smile and a relaxed tone as he thanks you for helping Fred and he steps to the side to reveal Fred holding a sign that says Part time Certified UMS Employee, Student, and full time Fred.)

Hi Graciana! Did you miss me! #speaker:Fred #mood:Happy

->END


==ChaosFinal==

I have a strong feeling I'm gonna turn around and see no one behind me, but I'm going to do it anyway to be absolutely sure I get what you're putting down, little man #speaker:Graciana #mood:happy
...
(Shit, no one's there, he's for sure suggesting I could be his mom...) #speaker:Graciana #mood:neutral
(Shit, I mean I thought about it before right? Right? It's perfectly fine if I do?) #speaker:Graciana #mood:think
(I never really wanted kids, but he wouldn't really be like having a baby, because I'm skipping the painful part of finding a partner first...)
(I mean I have a job, I could help pay off his suit and get him out of his contract with UMS...) 
(I could also take care of him after work and on weekends)
(Fuck, am I ready for this?)
Fuck, am I ready for this?
 
Fuck? #speaker:Fred #mood:neutral

Shit. #speaker:Graciana #mood:neutral

Shit? #speaker:Fred
 
I'm going to stop talking now. #speaker:Graciana #mood:neutral
Do not repeat any of what I just said outloud, those are Earthly customs to be used when frustrated or when someone cuts you off in interdimensional traffic. #speaker:Graciana #mood:neutral

Okay! #speaker:Fred #mood:happy

But... Dammit Fred... #speaker:Graciana #mood:think
This is the weirdest sentence I have ever thought of, or probably uttered outloud... But... 
Do you want me to be your mom?! #speaker:Graciana #mood:fear
 
... #speaker:Fred #mood:neutral
... #speaker:Graciana
...... #speaker:Fred

YES! #speaker:Fred #mood:galaxy 
You can be my teacher, mother, caretaker, main source of income-- #speaker:Fred #mood:pump
Hey now, that last part we gotta talk about.  #speaker:Graciana #mood:neutral
But you're fine with the rest?! #speaker:Fred

Damn right I am, my little star. #speaker:Graciana #mood:happy
The legal process is easy I think, it's just a matter of fixing your situation with UMS.

Woooooo! I'm going to be just like you! #speaker:Fred #mood:happy
 I can work in the diner, talk to people about their problems all day, serve food, make friends, go to school--
Alright alright alright, sure thing Fred.  #speaker:Graciana #mood:neutral
Let me clean up and then lets go see your new home, bud. #speaker:Graciana #mood:neutral
~GoToAppartment()

->END



==BadEnding==

*[Polar bear]
What's a polar bear? #speaker:Fred #mood:neutral

Oh, they used to be the apex predators of the Northern Icy planes of Earth, until Penguins evovled to hunt in packs and started hunting them.  #speaker:Graciana #mood:think

Oh, that's sad. #speaker:Fred #mood:sad

Yeah... #speaker:Graciana #mood:neutral
But they're really cute and fluffy! I think you could pull it off! #speaker:Graciana #mood:neutral

Really? #speaker:Fred #mood:pump

Yeah, and think, no one else would be wearing one, so you would be one of a kind! #speaker:Graciana #mood:happy

Oh, I like that! #speaker:Fred #mood:happy

Yeah! #speaker:Graciana #mood:happy

Yeah! #speaker:Fred #mood:pump

Okay, Polar Bear it is! #speaker:Graciana #mood:happy

But that still leaves me with a question... #speaker:Fred #mood:neutral

What's up hun?  #speaker:Graciana #mood:think
->BadEndingFinal
*[Frog]
Frogs? I thought people didn't like them because they're gross and slimey... #speaker:Fred #mood:sad

Some, yes.  #speaker:Graciana #mood:think
But most frogs are small cute little hopping green buddies!  #speaker:Graciana #mood:happy
I used to have a pet frog when I was little named Big Stinky!

Why did you name it Big Stinky? #speaker:Fred #mood:neutral

Well, he would always stare at me all day while I played at home with a... "Stinky eye" kind of look.  #speaker:Graciana #mood:think
So I called em Big Stinky because of it, and he didn't seem to mind.  #speaker:Graciana #mood:neutral
 
Huh, sounds like a weird frog... #speaker:Fred #mood:neutral

Yeah, he was. #speaker:Graciana #mood:think
But still, a cute little hopping amphibian! #speaker:Graciana #mood:happy

Hmmm... #speaker:Fred #mood:neutral
And you think my suit would look good as a frog?

Of course!  #speaker:Graciana #mood:happy

Alright, Frog it is! #speaker:Fred #mood:happy
I guess that only leaves the other big question... #speaker:Fred #mood:neutral

And what would that be, little hopping star?  #speaker:Graciana #mood:think

->BadEndingFinal

*[Puppy]
Well I think you would look adorable in a puppy suit! #speaker:Graciana #mood:neutral
You're already a loyal and adorable little star who everyone loves to be around, so it would fit the bill! #speaker:Graciana #mood:neutral

Fit the bill? #speaker:Fred #mood:neutral

Oh, right, that probably doesn't make sense to you yet. #speaker:Graciana #mood:think
It would make sense for someone as outgoing and innocent as you to be a puppy! #speaker:Graciana #mood:neutral

Hmmm, I think I get what you're saying... #speaker:Fred #mood:neutral
Right, a puppy it is! #speaker:Fred #mood:happy

But... #speaker:Fred #mood:neutral


->BadEndingFinal

==BadEndingFinal==

What do I do after that...? #speaker:Fred #mood:neutral

Oh, good point, a new activity would be useful to plan out before you quit... #speaker:Graciana #mood:think

Activity? Not job? #speaker:Fred #mood:neutral
Are they the same?

Well hun, love ya to death, but I don't know if you should be working at your age. #speaker:Graciana #mood:think
I know you're older than you look, but still, it doesn't feel right for you to be going from job to job. #speaker:Graciana #mood:neutral
Maybe you could look into school? #speaker:Graciana #mood:think
There are a lot of public schools on Earth, I'm sure they wouldn't mind having you there! #speaker:Graciana #mood:happy
Think of all the friends you could make!

Oh yeah! #speaker:Fred #mood:galaxy
I haven't really learned a whole lot, besides how to properly make package seals and delivery things places. #speaker:Fred #mood:pump 
And making friends my age could be really fun! #speaker:Fred #mood:happy

Well, around your age, but yeah! I think it could be great for you! #speaker:Graciana #mood:happy

Okay so school on earth after I quit UMS... #speaker:Fred #mood:neutral
How should I quit UMS?

Well, normally you need two weeks notice, and need to tell your boss... #speaker:Graciana #mood:think

Is there a faster way? #speaker:Fred #mood:neutral 

Well, I guess if you aren't getting paid anyways, you could just leave without saying anything and drop the suit off before you leave. #speaker:Graciana #mood:think

Oh yeah! I could fart in it too before I leave, so the next person who wears it will face my Cosmos! #speaker:Fred #mood:pump 
 
That's certainly something that you could do... #speaker:Graciana
One last "screw you" towards UMS would be fun! #speaker:Graciana #mood:happy

Yeah! #speaker:Fred #mood:happy

Okay, so do you want to take off the suit after you finish your drink? #speaker:Graciana #mood:think

You know what? #speaker:Fred #mood:neutral
I'm going to enjoy my swirl through my own two hands #speaker:Fred #mood:fuck

Oh? #speaker:Graciana #mood:thinnk

For too long have I been oppressed into drinking juice through tubes! #speaker:Fred #mood:angry

Oh boy, I can tell you've been watching some of the darker cartoons... #speaker:Graciana #mood:neutral

Yeah, even Frank closed his eyes at some parts... #speaker:Fred #mood:neutral 
But my point still stands!!! #speaker:Fred #mood:angry
Screw UMS, screw this Suit, and screw being forced to make friends while giving them stuff! #speaker:Fred #mood:angry
I'll only make friends with people who I want to talk to from now on!

(Fred puts his hands on the helmet, and swiftly pulls it off--) #speaker:Graciana #mood:neutral

?!?!?! #speaker:Graciana #mood:fear #scg:black

(A blinding white light fills the Diner...)
Ugh, my head--That ringing...
(I lose balance, and fall over...)
W-what...
What happened...?
...Fred...?

(I bring myself to my feet...)
Fred... Your helmet... Your suit...?
(The suit is on the ground in front of me all torn to shreds, safe for the helmet...) #pu:fhelm

Fred...? #pd: 
Where did you go?!
Fred?!

(I look out the window of the Diner...)
(Out to the stars...) 
(A new constellation... Staring back at me...?)
(A series of small stars...)
(Forming a confused and saddened face...)
Is that...
...
Fred...
...
What have I done...
Did I...
...
I'm so sorry...
    -> END
