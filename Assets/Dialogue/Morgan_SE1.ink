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

Oh well hello again Morgan nice to see you again so soon #speaker:Graciana #mood:neutral

Graciana, server of feasts, the pleasure is mine #speaker:Morgan #mood:neutral

Oh I like that title, makes me feel so fancy #speaker:Graciana #mood:neutral

What can this server of feasts do for you? #speaker:Graciana #mood:neutral

I would just like a coffee today, and your company if you would allow it #speaker:Morgan #mood:neutral

 But of course, coming right up my good lady #speaker:Graciana #mood:neutral

 So Graciana how does this fine morning grace you #speaker:Morgan #mood:neutral

 You know Morgan, I love this but if we are going to have a deeper conversation I dont know if I will be able to keep this up for a long time #speaker:Graciana #mood:neutral

 Very well feel free to speak in your normal tongue I will accomdate for your more simple words #speaker:Morgan #mood:neutral

 Thank you, I can only sound smart for so long #speaker:Graciana #mood:neutral

 To answer your previous I'm doing fine, but I think the bigger question is how are you doing #speaker:Morgan #mood:neutral

 Same as last #speaker:Morgan #mood:neutral

 hmmm and what would you like to talk about today Morgan #speaker:Graciana #mood:neutral
 
 
**[Talk about how she got like this]
~affectionM+=2
//good

 So you do remember what happened around the time this started to be a problem #speaker:Graciana #mood:neutral #sfx:GainedPoint

 I'm not sure #speaker:Morgan #mood:neutral

 The only thing I remember it what happened when I decided to step down from the crown#speaker:Morgan #mood:neutral 

 A younger, more ambitous Eldritch creature of the night decided she was going to challenge me like many others for my position #speaker:Morgan #mood:neutral

 Most don't realize the pain and suffering behind the crown, just the power, so it was not too unlikely to see this kind of event occur#speaker:Morgan #mood:neutral

 But when I was going to meet the challenge I for some reason unknown to me, didn't fight. I sat there, and allowed for her to take my crown and left without a word #speaker:Morgan #mood:neutral

 And are you sure it wasn't be you respected her or felt you didn't want to do this and you wanted to pass the crown on? #speaker:Graciana #mood:neutral

 ..................................... #speaker:Morgan #mood:neutral

 Since the before your realms were created I have reigned over the cosmos trail of death, collecting the souls of those who passed on #speaker:Morgan #mood:neutral

 I never once thought about anything else other than my glorious purpose #speaker:Morgan #mood:neutral

 I have no reason to wish for another to stand in my place #speaker:Morgan #mood:neutral

 And yet I let that very event occur #speaker:Morgan #mood:neutral

 well that is a mystery, and throughout your life did you have anyone with you #speaker:Graciana #mood:neutral

 Any companions or friends at all? You mentioned previously that you were alone, but surely not for your entire life? #speaker:Graciana #mood:neutral

 it is as you say, I have lived in solitude without need to communicate with lesser beings unless it was to demand the soul of those who were hiding from me  #speaker:Morgan #mood:neutral




->Next
**[Talk about life when she was Queen]
~affectionM-=2
//bad

When you were Queen were you happy? #speaker:Graciana #mood:neutral #sfx:LostPoint

The term was not yet known to me, but after interacting with some of your fellow mortals I have found most of them have exprienced this feeling a few times in their lives #speaker:Morgan #mood:neutral

I however, have only ever felt drive, purpose, a need to fill a role in this life that no one else could accomplish #speaker:Morgan #mood:neutral

That sounds almost beautiful in a way, even if that purpose is death #speaker:Graciana #mood:neutral

Think child, if you lived as long as I have, would you value your life equally? If a thousand years of serving feasts to those who entered these halls was your purpose would you feel needed?  #speaker:Morgan #mood:neutral

I guess? Maybe? Maybe not? I really dont know actually thats something I can't really comprehend #speaker:Graciana #mood:neutral

It is something many can not grasp, do not worry if it confuses you #speaker:Morgan #mood:neutral

But to put it simply, I knew in the depths of my soul I was needed, I was important, I was the thread that tied together reality itself by allowing a necessiary service to all realms #speaker:Morgan #mood:neutral

When I was challenged and gave up my crown, I felt that purpose slip, that drive, that feeling of worth all washed away for some reason unknown to me #speaker:Morgan #mood:neutral

And during all this time and all this change did you have anyone or anything to talk to or reach out to question on why? #speaker:Graciana #mood:neutral 

I lived in the void, the darkness where nothing can thrive and no one leaves, only upon death or loss by challenge does the ruler of the void step down #speaker:Morgan #mood:neutral

But you mentioned on a few occasions there being other people or I guess beings existing in the void with you right? So even if they aren't the closest of friends they went through the same expriences as you no? #speaker:Graciana #mood:neutral



->Next
**[Talk about what she wants right now]
~chaosM+=2
//chaos

I don't really know if I do want anything right now #speaker:Morgan #mood:neutral #sfx:CosmicPoint

It feels like my vision is hazed and I am unable to see whats in front of me #speaker:Morgan #mood:neutral

Kind of like life is flying by you but you can't really make sense of what is happening or don't understand it? #speaker:Graciana #mood:neutral

In a sort, I'm not sure how to properly describe it as I do and feel nothing most of the time. #speaker:Morgan #mood:neutral

I used to feel a strong passion, almost a fire burning within my chest #speaker:Morgan #mood:neutral

Now that the flame is out, I don't know how to reignite it #speaker:Morgan #mood:neutral

Just left tending to the embers that remain in the field of desolate ash #speaker:Morgan #mood:neutral

That's some deep stuff right there #speaker:Graciana #mood:neutral

Again I can't say everything I say will mean something to you, or will have signifigant impact on any of this #speaker:Graciana #mood:neutral

But I did go through a similar time, a lot in my life didn't matter anymore, no matter how much it did before #speaker:Graciana #mood:neutral

I wished everyday for purpose, for the old feelings that used to make me who I was, but all I felt was like a small speck in a universe bigger than I could ever imagine  #speaker:Graciana #mood:neutral

But after I stopped living for other people, and got a little freedom to explore where I wanted to be in life it got a little better #speaker:Graciana #mood:neutral

Explain, how did it get better from this freedom and exploration? #speaker:Morgan #mood:neutral

Well I was stuck in a bad place both physically and mentally #speaker:Graciana #mood:neutral

My home life wasn't great, I didn't have friends, no one worked as hard as I did, no one understood my lifestyle or desires, and I was constantly under pressure to do things I wasn't interested in  #speaker:Graciana #mood:neutral

After I cut those people and places out of my life it got a little better, I started working here, started seeing new faces and hearing new voices#speaker:Graciana #mood:neutral

So a change in enviroment aided in this search to better your mind #speaker:Morgan #mood:neutral

In a way yes #speaker:Graciana #mood:neutral

Interesting I have existed in the depths of the void for the longest time that when I left I felt empty. Only ruling in the shadows and hearing others voices and souls drift past me as they pass on can be strange to most #speaker:Morgan #mood:neutral

Did you enjoy it?  #speaker:Graciana #mood:neutral

I didn't know what enjoyment was until it was gone #speaker:Morgan #mood:neutral
Ah, don't we all wish we could tell when we were in the good times before they were gone #speaker:Graciana #mood:neutral
Now that is as you say "Deep" #speaker:Morgan #mood:neutral
Why thank you Morgan #speaker:Graciana #mood:neutral


->Next

==Next==

The void is an unkind place Graciana, the ones you know as friends are not a commonplace pratice in the darkness from which monsters are born #speaker:Morgan #mood:neutral
Well..... yeah I guess I don't really know much about where you are from #speaker:Graciana #mood:neutral
But I have to ask and please let me know if Im wrong  #speaker:Graciana #mood:neutral
Isn't O'Ryan a void creature too? #speaker:Graciana #mood:neutral
This name does sound familiar though he is not of my realm last I remember 
Oh so you do know him? #speaker:Graciana #mood:neutral
I've heard of his empire he is slowly building over the centuries 
Empire? #speaker:Morgan #mood:neutral
Yes, his many chained operations of business are becoming more well known of recent years#speaker:Graciana #mood:neutral
I've been weary to step foot in one as my presence may cause unfathomable consquences if we were to cross paths #speaker:Morgan #mood:neutral
Oh? Like? #speaker:Graciana #mood:neutral
Im not sure myself, but when any powerful beings meet there normally is not a friendly conversation. It is either conflict or mayhem #speaker:Morgan #mood:neutral
I see, with that being said though, have you met with O'Ryan before? #speaker:Graciana #mood:neutral
I have not #speaker:Morgan #mood:neutral
Well even if under normal cicumstances you might not meet under great standing, what if you try and approach him as a fellow powerful mystical being who is in need of help? #speaker:Graciana #mood:neutral
Maybe ask for help or advice on what he would do in your position?  #speaker:Graciana #mood:neutral
..................... I have not thought of this before #speaker:Morgan #mood:neutral
the chances are slim, but having a ally of his caliber could prove to be useful 
And by ally you mean friend? #speaker:Graciana #mood:neutral
I have spoken clearly, as I mentioned before the concept of friends is not one our peoples are familiar with #speaker:Morgan #mood:neutral
But a potiental ally could be exactly what I need to reclaim my drive, someone to push me, to give me a renewed purpose, a new spark! #speaker:Morgan #mood:neutral
Do you happen to know when O'Ryan visits his domains? #speaker:Morgan #mood:neutral
Usually at the end of the day after I'm done with my shift I usually see him for a few seconds before he heads out #speaker:Graciana #mood:neutral
Seconds you say? He must be quick with his words to achieve conversation with such haste #speaker:Morgan #mood:neutral
More like he doesn't have many words to say so he keeps it short #speaker:Graciana #mood:neutral
I could leave a message for you if you would like, maybe an introduction? #speaker:Graciana #mood:neutral
I did only recently start working here through so Im not sure I carry much weight in the matter#speaker:Graciana #mood:neutral
Do not worry yourself with such pleasentries, I will reach out to him in my own way #speaker:Morgan #mood:neutral
But before do I must ask, what would you use to define his presence? What do you feel when you stand next to him what is the description that fits best for O'Ryan? #speaker:Morgan #mood:neutral
Well..........  #speaker:Graciana #mood:neutral

**[Ominous I guess?]
 I feel like I am looking at him, but not really looking at anything at the same time #speaker:Graciana #mood:neutral 
 He is just a strangely absent but present since he is actually a big guy too, its just I'm not sure If I stuck my hand into him if I would hit anything you know? #speaker:Graciana #mood:neutral
 Your description is useful, you have my thanks #speaker:Morgan #mood:neutral
 Someone who can be both present but also lack a material form could be quite powerful indeed, a perfect ally #speaker:Morgan #mood:neutral
 And an even better friend? #speaker:Graciana #mood:neutral
 I'm still unsure if I am going to fully understand why you push this notion of friendship, but as I previously stated I do not value such things as I have yet to see them #speaker:Morgan #mood:neutral
 Fair enough but I will keep pushing till you try it! #speaker:Graciana #mood:neutral
 Be careful for how deep you dig before you end up falling into you own actions #speaker:Morgan #mood:neutral
 ..................................... #speaker:Graciana #mood:neutral
 Of course! But we have been talking for a bit now would you like anything to eat or drink? #speaker:Graciana #mood:neutral



->Final
**[Overwhelming]
I haven't found myself to do really anything much that kind of stand in awe whenver I talk to him#speaker:Graciana #mood:neutral
 His body, his few words, his strange galaxy patterns, all of it is pretty overwhelming for just a human like me #speaker:Graciana #mood:neutral
 But I don't think hes scary or strikes terror into my heart or anything like that. Hes just a whole lot all at once #speaker:Graciana #mood:neutral
 Your command over words paints me a picture of his image in my mind, well done you have my thanks #speaker:Morgan #mood:neutral
 Oh have you actually never seen what he looks like? #speaker:Graciana #mood:neutral
 No I have not, however it seems his reputation precedes him in his success in both physical and finacial power gianed #speaker:Morgan #mood:neutral
 Sure I guess you could say that #speaker:Graciana #mood:neutral
 You have been quite helpful Graciana, O'Ryan should be lucky to have such a worker as you #speaker:Morgan #mood:neutral
 Of course! But we have been talking for a bit now would you like anything to eat or drink?#speaker:Graciana #mood:neutral



->Final
**[Kinda strange]
 Im not saying he is strange in a bad way, I am just saying he is at best one of the most unqiue beings or people I have ever met #speaker:Graciana #mood:neutral
 This is my first time really expriencing new outerworld peoples and he is the one who stands out the most in just about every way #speaker:Graciana #mood:neutral
 I mean he is massively large sometimes, other times he is thin as a toothpick, and I can never really tell when he is happy or showing any real emotion execept anger which I dare not wish anyone to see ......... ever ..... at all. #speaker:Graciana #mood:neutral
 Exactly how I have heard him being described, duely noted #speaker:Morgan #mood:neutral
 You have my thanks for the clarifcation on the matter #speaker:Morgan #mood:neutral
 Of course! But we have been talking for a bit now would you like anything to eat or drink? #speaker:Graciana #mood:neutral


->Final
==Final==
 Perhaps another time, for now I must think on what is next to come and plan out my approach to O'Ryan.  #speaker:Morgan #mood:neutral
 Your insight and advice has proven to be useful as always, I will take my leave now. #speaker:Morgan #mood:neutral 
Alright then, See you soon Morgan #speaker:Graciana #mood:neutral

Pleasure talking to you as always! #speaker:Graciana #mood:neutral
~BAMLevel=1
~timeOfDay="afternoon"
~currentConvo="MMG2"
~QuickSave()
->MainBAD

