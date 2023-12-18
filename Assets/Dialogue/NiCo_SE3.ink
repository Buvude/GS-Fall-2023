->begin
INCLUDE globals.ink


==begin==
Hey NiCo! #speaker:Graciana #mood:happy

Oh... Hey, Graciana. #speaker:NiCo #mood:neutral

    * [What's goin' on?]
    
    What's goin' on, NiCo? #speaker:Graciana
    
    Nothing, just the usual. #speaker:NiCo
    
    Usual being...? #speaker:Graciana #mood:think
    ->CalculateEnding
//Here, divert to the corresponding ending. I gotta discuss with you (David) about how to integrate that exactly. Might be better to move some stuff around, if possible.
//If not, at least I got it in inky so i can just copy-paste if needed lol
* [Oops, nevermind!]
    ~GoToDiner()
    -> DONE
   
   
===CalculateEnding===
{
-chaosN>=chaosTotalN:
    ->NiCoChaosEnding
-affectionN>=0:
    ->NiCoGoodEnding
-affectionN<0:
    ->NiCoBadEnding
}
==NiCoGoodEnding==
~affectionOR+=1
~convo_numberN+=1
~convo_numberOR+=1
... #speaker:NiCo
You know what? No.
Things are actually fairly good.

Oh! I'm really glad to hear that! #speaker:Graciana
What's going on?

Well, I talked to my friend in the mechanical & maintenance department. #speaker:NiCo #mood:happy
They found some definitive evidence that clears any fault on my end.
The incident that damaged me was 100% the fault of Tundra Enterprises.

Oh my gosh! This is huge! #speaker:Graciana
I remember you mentioning how borderline impossible this was... And look what happened!
What was the evidence that they found? #speaker:Graciana #mood:think

It turns out that the battery in the TundraTruck engine was faulty. A lot of them are made on the cheap, and supposedly this one was not properly calibrated for my model, being a First Gen. #speaker:NiCo
And since there is nothing in any writing or manuals about battery compatability with different models... #speaker:NiCo #mood:neutral
Legally, they have no choice but to admit fault. Even with all the money in the world, they cannot change what happened in the past, without a doubt. #speaker:NiCo #mood:happy

This is so amazing...! #speaker:Graciana #mood:happy
So, what does this mean for you? Now what?

Well, I'm going to be getting a full repair, first and foremost. #speaker:NiCo
The case hasn't been fully settled, however it's looking like I'll be receiving hefty compensation, as well as extended paid time off.
I might be able to take a vacation for once...!
Or even better...
I might be able to pay off a major chunk of my roboticization loan!
And even EVEN better...
I could retire early!

That's incredible, NiCo! #speaker:Graciana
Any ideas on where you'd wanna go?

There are a few ideas... #speaker:NiCo #mood:neutral
Maybe a beach?

... #speaker:Graciana #mood:neutral
I think beaches are considered dangerous for electronics...

Oh... Right. Well, I'm sure there's somewhere! #speaker:NiCo
Maybe the countryside, or somewhere deep in space...
I don't know! There's so much opportunity for me, finally! #speaker:NiCo #mood:happy

I'm so happy for you, NiCo! #speaker:Graciana #mood:happy

Yes! I just wanted to come by to thank you, Graciana. #speaker:NiCo #mood:happy

Thank me...? #speaker:Graciana #mood:think

Without your incessant pushing, I would have never taken the plunge into solving this problem. #speaker:NiCo
I would have sat around feeling sorry for myself, getting worse until I inevitably become inoperable. #speaker:NiCo #mood:neutral
You gave me the push I needed. Thank you. #speaker:NiCo #mood:happy

Well... I'm flattered. #speaker:Graciana #mood:happy
I was just doing my job, after all! #esfo: 
->DONE
//CG goes here

==NiCoBadEnding==
~affectionOR-=1
~convo_numberN+=1
~convo_numberOR+=1
Not great. #speaker:NiCo
N-not great a-a-a-at all, actually. #speaker:NiCo #mood:error

Are you... okay? #speaker:Graciana #mood:think
You're glitching a bit more than usual...

I'm f-fine. #speaker:NiCo #mood:neutral
Just a few scrapes, is all.

Scrapes?

Y-yea. #speaker:NiCo
I tripped the other day while on m-m-my way back to my apartment.
I fell pretty h-h-h-h-h-hard. #speaker:NiCo #mood:error

Oh no... #speaker:Graciana #mood:sad
How're you feeling? Have you been looked at? #speaker:Graciana #mood:think

N-no, I can't afford it. #speaker:NiCo #mood:neutral
J-j-just like everything else... #speaker:NiCo #mood:sad

I'm sorry... #speaker:Graciana
Is there anything I can do to help...?

No. Not anymore. #speaker:NiCo
I actually can't stay m-m-m-much later. I have to get back to my sh-sh-sh-shift. #speaker:NiCo #mood:error
Excuse m-m-me.

(NiCo tries to pull themself out of the booth, but...) #speaker:Graciana
<i>(CLANK!)</i> #speaker:NiCo #mood:error
(Their leg comes undone, and they come crashing down to the floor!) #speaker:Graciana #mood:fear
NiCo! #speaker:Graciana

G-G-G-G-G-G-G-G-Graciana... #speaker:NiCo

(In a moment, NiCo's screen goes blank...) #speaker:Graciana #mood:sad
(After a brief pause, it turns back on to...)
A command prompt...?
(A small keyboard pops out of NiCo's stomach latch.)

Maybe...
Maybe I can do something, eventually.
My programming skills are a little rusty, but...
I'll see what I can do, NiCo... #esfo: 
->DONE
//CG goes here

==NiCoChaosEnding==
~chaosOR+=1
~convo_numberN+=1
~convo_numberOR+=1
Actually... #speaker:NiCo
Things have gotten rather interesting since last time we chatted, Graciana. #speaker:NiCo #mood:smug

What do you mean "interesting"? #speaker:Graciana #mood:think

Well... #speaker:NiCo
I talked to a handful of other workers at Tundra. And we came up with a list of demands that we presented to the higher ups.

Oh, that's great! #speaker:Graciana #mood:happy
What happened after that?

... #speaker:NiCo #mood:neutral
They laughed us out of the room.

Oh... #speaker:Graciana #mood:sad

But... #speaker:NiCo

But...? #speaker:Graciana #mood:think

We are currently doing what is known as a "strike." #speaker:NiCo #mood:happy
En mass, we are refusing to work until our demands are met. And it has been going well so far.

NiCo... #speaker:Graciana
That's wonderful! #speaker:Graciana #mood:happy

Yes, I think we might get through to them. #speaker:NiCo
Although... #speaker:NiCo #mood:neutral

Although...? #speaker:Graciana #mood:think

Things might be escalating. #speaker:NiCo

Escalating? #speaker:Graciana

Tundra started sending out units to counter-protest. #speaker:NiCo
And some of them... Got a little violent, to say the least. #speaker:NiCo #mood:sad

Violent?! #speaker:Graciana #mood:fear

Yes, unfortunately... #speaker:NiCo
But we have been fighting back. #speaker:NiCo #mood:neutral
We will not fall to Tundra! #speaker:NiCo #mood:angry
We will take back the world that belongs to us!

... #speaker:Graciana #mood:neutral
Hell yeah! That's the spirit! #speaker:Graciana #mood:happy

And all of this is thanks to you, Graciana. #speaker:NiCo #mood:neutral

Me...? #speaker:Graciana #mood:think

Yes, you. #speaker:NiCo
Without your inspiration, I would not have ever been pushed to act like this.
I am doing things I once never believed were possible for me.
I even met someone that knows a thing or two about repairs, and they managed to help me with my leg a little bit! #speaker:NiCo #mood:happy

Well... #speaker:Graciana #mood:neutral
That's amazing! #speaker:Graciana #mood:happy
I'm so glad for you, NiCo.
Just... Be careful, y'know? #speaker:Graciana #mood:think

Of course, I understand. #speaker:NiCo
We shall see. #esfo: 
->DONE
//CG goes here

