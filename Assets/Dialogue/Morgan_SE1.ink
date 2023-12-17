INCLUDE globals.ink
INCLUDE BADialogue.ink
//2 chaos options
(Morgan is back...) #speaker:Graciana #mood:neutral

* [(Approach her)]
    ->Start
* [(Leave her be)]
(Maybe I'll leave her to brood for a bit...)
~GoToDiner()
    -> DONE
==Start==
~convo_numberM=2

Hello again, Morgan! Nice to see you so soon. #speaker:Graciana #mood:happy

Graciana, server of feasts! The pleasure is mine. #speaker:Morgan #mood:happy

Oh, I like that title; it makes me feel so fancy! #speaker:Graciana
What can this server of feasts do for you? #speaker:Graciana #mood:neutral

I would just like a coffee today, and your company if you would allow it. #speaker:Morgan #mood:neutral

But of course, coming right up, my good lady. #speaker:Graciana #mood:happy #scg:black
...

So, Graciana, how does this fine morning grace you? #speaker:Morgan #mood:neutral #ecg: 

You know Morgan, I love this, but if we're going to have a deeper conversation, I don't know if I can keep up with your... Elegant language. #speaker:Graciana #mood:sad

Very well, feel free to speak in your normal tongue; I will accommodate your simpler words. #speaker:Morgan #mood:neutral

Thank you; I can only sound smart for so long. #speaker:Graciana #mood:neutral

To answer your previous question, I'm doing fine, but I think the bigger question is, how are you doing? #speaker:Morgan #mood:think

Same as last time. Still entrapped in an internal battle with my own "nation of stags." #speaker:Morgan #mood:sad

Hmmm... Is there anything you'd wanna talk about today? Maybe get your mind off things? #speaker:Graciana #mood:think
 
Anything you wish, Graciana. I am sure a Human such as yourself has plenty of questions. #speaker:Morgan #mood:neutral

**[How did you get like this?]
~affectionM+=2
//good

So, you do remember what happened around the time this started to be a problem? #speaker:Graciana #mood:think #sfx:gainedPoint

I'm not sure. #speaker:Morgan #mood:sad
The only thing I remember is what happened when I decided to step down from the crown. #speaker:Morgan #mood:neutral
A younger, more ambitious Eldritch creature of the night decided she was going to challenge me, like many others for my position. #speaker:Morgan #mood:neutral
Most don't realize the pain and suffering behind the crown, just the power... #speaker:Morgan #mood:sad
So it was not too unlikely to see this kind of event occur. #speaker:Morgan #mood:neutral
But when I was going to meet the challenger, for some reason unknown to me, I did not fight. 
I sat there and allowed her to take my crown, and left without a word. #speaker:Morgan #mood:sad

And are you sure it wasn't because you respected her, or felt you didn't want to do this, and that you wanted to pass the crown on? #speaker:Graciana #mood:think

... #speaker:Morgan #mood:sad
Since before your realms were created, I have reigned over the cosmos; a trail of death, collecting the souls of those who passed on. #speaker:Morgan #mood:neutral
I never once thought about anything else other than my glorious purpose. #speaker:Morgan #mood:neutral
I have no reason to wish for another to stand in my place. #speaker:Morgan #mood:neutral
And yet, I let that very event occur... #speaker:Morgan #mood:sad

Well, that is a mystery... #speaker:Graciana #mood:neutral
Throughout your life, did you have anyone with you? #speaker:Graciana #mood:think
Any companions or friends at all? You mentioned previously that you were alone, but surely not for your entire life...? #speaker:Graciana #mood:think

It is as you say... #speaker:Morgan #mood:sad 
I have lived in solitude without the need to communicate with lesser beings, unless it was to demand the soul of those who were hiding from me. #speaker:Morgan #mood:neutral
->Next
*[Life when you were Queen?]
~affectionM-=2
//bad

When you were Queen, were you happy? #speaker:Graciana #mood:think #sfx:lostPoint

The term was not yet known to me, but after interacting with some of your fellow mortals, I have found most of them have experienced this feeling a few times in their lives. #speaker:Morgan #mood:neutral

I, however, have only ever felt drive, purpose, a need to fill a role in this life that no one else could accomplish. #speaker:Morgan #mood:neutral

That sounds almost beautiful in a way, even if that purpose is... Death... #speaker:Graciana #mood:neutral

Think, child... #speaker:Morgan #mood:neutral
if you lived as long as I have, would you value your life equally? #speaker:Morgan #speaker:sad
If a thousand years of serving feasts to those who entered these halls was your purpose, would you feel needed? #speaker:Morgan #mood:neutral

I guess? Maybe? Maybe not? I really don't know. #speaker:Graciana #mood:think
Actually, that's something I can't really comprehend. #speaker:Graciana #mood:neutral

It is something many cannot grasp; do not worry if it confuses you. #speaker:Morgan #mood:neutral
But to put it simply, I knew in the depths of my soul I was needed--I was important. 
I was the thread that tied together reality itself by allowing a necessary service to all realms. #speaker:Morgan #mood:neutral
When I was challenged and gave up my crown, I felt that purpose slip, that drive, that feeling of worth all washed away for some reason unknown to me. #speaker:Morgan #mood:sad

And during all this time and all this change, did you have anyone or anything to talk to, or reach out to question on why? #speaker:Graciana #mood:think

I lived in the void, the darkness where nothing can thrive and no one leaves; only upon death or loss by challenge does the ruler of the void step down. #speaker:Morgan #mood:neutral

But you mentioned on a few occasions there being other people or, I guess, beings existing in the void with you, right? #speaker:Graciana #mood:think
So even if they aren't the closest of friends, they went through the same experiences as you, no? #speaker:Graciana #mood:neutral
->Next
*[Talk about what she wants right now]
~chaosM+=2
//chaos

What do you want right now? #speaker:Graciana #mood:think #sfx:cosmicPoint
Like, if you could be or do anything you wanted...

I don't really know if I do want anything right now. #speaker:Morgan #mood:neutral

It feels like my vision is hazed, and I am unable to see what's in front of me. #speaker:Morgan #mood:sad

Kind of like life is flying by you, but you can't really make sense of what is happening or don't understand it? #speaker:Graciana #mood:think

In a sort, I'm not sure how to properly describe it as I do and feel nothing most of the time. #speaker:Morgan #mood:neutral

I used to feel a strong passion, almost a fire burning within my chest. #speaker:Morgan #mood:happy

Now that the flame is out, I don't know how to reignite it. #speaker:Morgan #mood:sad
Just left tending to the embers that remain in the field of desolate ash.

That's some deep stuff right there... #speaker:Graciana #mood:neutral

Again, I can't promise everything I say will mean something to you, or will have a significant impact on any of this... #speaker:Graciana #mood:think
But I did go through a similar time; I suddenly felt a lot of stuff in my life just didn't have the same glow it used to. #speaker:Graciana #mood:neutral
I wished every day for purpose, for the old feelings that used to make me who I was, but all I felt was like a small speck, in a universe bigger than I could ever imagine. #speaker:Graciana #mood:neutral
But after I stopped living for other people, and got a little freedom to explore where I wanted to be in life, it got a little better. #speaker:Graciana #mood:neutral

Explain, how did it get better from this freedom and exploration? #speaker:Morgan #mood:neutral

Well, I was stuck in a bad place both physically and mentally. #speaker:Graciana #mood:think
My home life wasn't great, I didn't really have friends... 
No one worked as hard as I did, no one understood my lifestyle or desires, and I was constantly under pressure to do things I wasn't interested in...
After I cut those people and places out of my life, it got a little better. I started working here, started seeing new faces, and hearing new voices. #speaker:Graciana #mood:neutral

So... A change in environment aided in this search to better your mind. #speaker:Morgan #mood:neutral

In a way, yeah. #speaker:Graciana #mood:neutral

Interesting... #speaker:Morgan #mood:neutral
I have existed in the depths of the void for the longest time, that when I left, I felt empty. #speaker:Morgan #speaker:sad
Only ruling in the shadows and hearing others' voices and souls drift past me as they pass on can be strange to most. #speaker:Morgan #mood:neutral

Did you enjoy it? #speaker:Graciana #mood:think

I didn't know what enjoyment was until it was gone. #speaker:Morgan #mood:saddened
Ah, don't we all wish we could tell when we were in the good times before they were gone. #speaker:Graciana #mood:happy

Now that is, as you say... "Deep?" #speaker:Morgan #mood:neutral

Why thank you, Morgan. #speaker:Graciana #mood:happy


->Next

==Next==

The void is an unkind place, Graciana. The ones you know as "friends" are not a commonplace practice in the darkness from which monsters are born. #speaker:Morgan #mood:neutral

Well... yeah, I guess I don't really know much about where you're from. #speaker:Graciana #mood:think
But I have to ask, and please let me know if I'm wrong... #speaker:Graciana #mood:neutral
Isn't O'Ryan a Void creature too? #speaker:Graciana #mood:think

O'Ryan, as in the owner of this establishment? They do sound familiar, but they are not of my realm last I remember. #speaker:Morgan

Oh, so you do know them? #speaker:Graciana #mood:think

I've heard of the empire they have slowly been building over the centuries. #speaker:Morgan #mood:neutral

Empire?! #speaker:Graciana #mood:fear

Yes, their many chained operations of business are becoming more well-known of recent years. #speaker:Morgan #mood:neutral
I've typically been weary to step foot in one, as my presence may cause unfathomable consequences if we were to cross paths. #speaker:Morgan #mood:neutral

Oh? Like? #speaker:Graciana #mood:think

I'm not sure myself, but when any powerful beings meet, there normally is not a friendly conversation. It is either conflict or mayhem. #speaker:Morgan #mood:neutral

I see... With that being said though, have you met with O'Ryan before? #speaker:Graciana #mood:think

I have not. #speaker:Morgan #mood:neutral

Well, even if under normal circumstances you might not meet under great standing, what if you try and approach them as a fellow powerful mystical being who is in need of help? #speaker:Graciana #mood:think
Maybe ask for help or advice on what they would do in your position?

...I have not thought of this before. #speaker:Morgan #mood:neutral
The chances are slim, but having an ally of his caliber could prove to be useful.

And by ally, you mean friend? #speaker:Graciana #mood:think

I have spoken clearly, as I mentioned before, the concept of friends is not one our peoples are familiar with. #speaker:Morgan #mood:sad
But a potential ally could be exactly what I need to reclaim my drive, someone to push me, to give me a renewed purpose, a new spark! #speaker:Morgan #mood:happy
Do you happen to know when O'Ryan visits their domains? #speaker:Morgan #mood:neutral

Usually at the end of the day after I'm done with my shift, I usually see them for a few seconds before they head out. #speaker:Graciana #mood:neutral

Seconds, you say? O'Ryan must be quick with their words to achieve conversation with such haste. #speaker:Morgan #mood:neutral

More like they don't have many words to say, so they keep it short. #speaker:Graciana #mood:think
I could leave a message for you if you would like, maybe an introduction? #speaker:Graciana #mood:think
I did only recently start working here though, so I'm not sure I carry much weight in the matter. #speaker:Graciana #mood:neutral

Do not worry yourself with such pleasantries; I will reach out to them in my own way. #speaker:Morgan #mood:neutral
But before I do, I must ask, what would you use to define O'Ryan's presence? What do you feel when you stand next to them--What is the description that fits best for O'Ryan? #speaker:Morgan #mood:neutral

Well...  #speaker:Graciana #mood:neutral

*[Ominous I guess?]
I feel like I'm looking at them, but not really looking at anything at the same time... #speaker:Graciana #mood:think
They're just strangely absent, but present since they're actually a big guy too; it's just, I'm not sure if I stuck my hand into them if I would hit anything, you know?

Your description is useful; you have my thanks. #speaker:Morgan #mood:neutral
Someone who can be both present but also lack a material form could be quite powerful indeed, a perfect ally. #speaker:Morgan #mood:neutral

And an even better friend? #speaker:Graciana #mood:think

I'm still unsure if I am going to fully understand why you push this notion of friendship... #speaker:Morgan #mood:sad
But as I previously stated, I do not value such things as I have yet to see them. #speaker:Morgan #mood:neutral

Fair enough, but I'll keep pushing 'til you try it! #speaker:Graciana #mood:happy

Be careful for how deep you dig before you end up falling into your own actions. #speaker:Morgan #mood:neutral

... #speaker:Graciana #mood:neutral
Of course! But we've been talking for a bit now; would you like anything to eat or drink? #speaker:Graciana #mood:think

->Final
*[Overwhelming]
I haven't found myself to do really anything, other than kinda stand in awe whenever I talk to them. #speaker:Graciana #mood:neutral
Their body, their few words, their strange galaxy patterns... #speaker:Graciana #mood:think
All of it is pretty overwhelming for a human like me. #speaker:Graciana #mood:neutral
But I don't think they're scary or strikes terror into my heart or anything like that. It's just a whole lot all at once. #speaker:Graciana #mood:neutral

Your command over words paints me a picture of O'Ryan's image in my mind... #speaker:Morgan #mood:neutral
Well done, you have my thanks. #speaker:Morgan #mood:happy

Oh, have you actually never seen what O'Ryan looks like? #speaker:Graciana #mood:think

No, I have not; however, it seems their reputation precedes them in their success in both physical and financial power gained. #speaker:Morgan #mood:neutral

Sure, I guess you could say that. #speaker:Graciana #mood:neutral

You have been quite helpful, Graciana. O'Ryan should be lucky to have such a worker as you. #speaker:Morgan #mood:happy

Of course! But we have been talking for a bit now--would you like anything to eat or drink? #speaker:Graciana #mood:think

->Final
*[Kinda strange]
I'm not saying they're strange in a bad way... #speaker:Graciana #mood:think
I'm just saying they are, at best, one of the most unique beings or people I have ever met. #speaker:Graciana #mood:neutral
This is my first time really experiencing new outerworld people, and they're the one who stands out the most in just about every way. #speaker:Graciana #mood:think
I mean, they're massively large sometimes, and other times, thin as a toothpick... 
I can never really tell when they're happy, or showing any real emotion except anger, which I dare not wish anyone to see... Ever... At all. #speaker:Graciana #mood:neutral

Exactly how I have heard them being described, duly noted. #speaker:Morgan #mood:neutral
You have my thanks for the clarification on the matter. #speaker:Morgan #mood:neutral

Of course! But we have been talking for a bit now; would you like anything to eat or drink? #speaker:Graciana #mood:think


->Final
==Final==
Perhaps another time... #speaker:Morgan #mood:sad
For now, I must think on what is next to come and plan out my approach to O'Ryan. #speaker:Morgan #mood:neutral
Your insight and advice have proven to be useful, as always; I will take my leave now. #speaker:Morgan #mood:happy

Alright then, see you soon, Morgan. #speaker:Graciana #mood:neutral
Pleasure talking to you, as always! #speaker:Graciana #mood:happy

(Morgan gets up and floats over to the exit portal, leaving the diner.) #speaker:Graciana #mood:neutral #ss:Morgan:blank

Alright...
Time to see if Chef Swatts needs anything...

~BAMLevel=1
~timeOfDay="afternoon"
~currentConvo="MMG2"
~QuickSave()
->MainBAD

