INCLUDE globals.ink

//my mental breakdown aside, her character and arc is really good. the relationship between her and graciana is so fun and cool
//dom you're genuinely a phenomenal writer just PLEASE use spell check and follow my ink formatting more, i BEG OF YOU
//:) spell is checked and form is matted

(Morgan is sitting alone, contemplating something...) #speaker:Graciana #mood:think

* [(Approach her)]
    -> Start
* [(Leave her be)]
(Just not yet...) #speaker:Graciana #mood:neutral
~GoToDiner()
    ->DONE

==Start==
~convo_numberM=4

Well well well, if it isn't my favorite Eldritch customer. What can I get for ya today, Morgan? #speaker:Graciana #mood:happy

Hello Graciana, pleasure to see you as always. #speaker:Morgan #mood:neutral
I think today I will just have a slice of marble cake, with black fondant and red frosting in the shape of roses #speaker:Morgan #mood:neutral

Oooo, such a specific and fancy request makes me think that something amazing has happened! What's the good news Morgan!?! #speaker:Graciana #mood:happy

The request had nothing to do with anything occurring outside the diner, I simply saw it in one of your Earth programs and it caught my eye. #speaker:Morgan #mood:neutral

Oh... #speaker:Graciana #mood:sad

But as you stated previously, something did happen. #speaker:Morgan #mood:neutral

I knew it! Tell me everything! #speaker:Graciana #mood:happy

Cake first, please. #speaker:Morgan #mood:neutral

Right, no that makes sense. #speaker:Graciana #mood:neutral
One second... #speaker:Graciana #mood:neutral #scg:black
...
Alright, tell me what happened! #speaker:Graciana #mood:happy #ecg: 

Well, you suggested I reach out to those around me, and for those who would like to help see me come to power, better myself, and all of the friendships benefits you listed previously... #speaker:Morgan #mood:think

Annnnd? #speaker:Graciana #mood:think

I decided to meet with O'Ryan briefly, we talked for a few minutes outside one of their other establishments I saw they frequented towards the afternoon. #speaker:Morgan #mood:neutral

Oooohhhhh, how did it go?! #speaker:Graciana #mood:think

I discussed with him my goals and position, and how someone has been trying to get me to branch myself out to those around me, to help me grow and create friendships. #speaker:Morgan #mood:think

And what did he say? #speaker:Graciana #mood:think

A few words, and a tip of his void-filled hat as he left. You were right about his very short and to-the-point personality. #speaker:Morgan #mood:neutral
I am not quite sure what to do about him at the moment. If I am to be completely honest, they are a bit of an enigma.#speaker:Morgan #mood:think
He neither stated he would directly support me, nor be my friend, but I felt there was some kind of hidden meaning or message behind his words. #speaker:Morgan #mood:think

Oh? Like he said something in a secret message to not alert other Gods of your talk? #speaker:Graciana #mood:think

Perhaps, but I believe it was more on the lines of "he was leading me on to something," I just cannot find what it is #speaker:Morgan #mood:neutral

What exactly did he say? #speaker:Graciana #mood:think

Well, we conversed in the ancient tongue of the gods, so I don't know the exact translation to your language, but it would probably be somewhere around the lines of... #speaker:Morgan #mood:neutral
"You may have me, if you wish." #speaker:Morgan #mood:think

Oh my... #speaker:Graciana #mood:neutral

{
-chaosM>=chaosTotalM:
    ->MorganChaosEnding
-affectionM>=0:
    ->MorganGoodEnding
-else:
    ->MorganBadEnding
}
//Divert Endings here pretty please with a cherry on top
==MorganGoodEnding==
I think that means they're offering themself as a friend! #speaker:Graciana #mood:happy

Really? Just like that? #speaker:Morgan #mood:think
I ask for help, and they would be willing to potentially throw the universe out of balance because I said please and thank you? #speaker:Morgan #mood:nuetral

I mean, did you say please and thank you? #speaker:Graciana #mood:think

Yes, it was disturbing for those words to be coming out of my mouth. #speaker:Morgan #mood:sad
I believe I fell ill moments later... #speaker:Morgan #mood:neutral

Oh boy, we'll find another way for you to express nice things, then. #speaker:Graciana #mood:think

Please do... #speaker:Morgan #mood:sad

...#speaker:Graciana #mood:neutral

... #speaker:Morgan
 
Are you ok? #speaker:Graciana #mood:think

I fear you are changing me, for the better and worse #speaker:Morgan #mood:neutral

Let's try and avoid the "worse" part, then. #speaker:Graciana #mood:neutral
But that's good news that O'Ryan is willing to be a friend, or ally, or whatever you wanna call him, to restore you to your former power. Did they say how they're gonna do it? #speaker:Graciana #mood:think

Not a word, just that one phrase mixed with a "hello" and a "good evening..." #speaker:Morgan #mood:neutral

Wow, O'Ryan really does say next to nothing, huh... #speaker:Graciana #mood:think

So how do you think they'll go about it? #speaker:Morgan #mood:neutral


*[Give you some of their power!]

Maybe O'Ryan will give you a boon of some of their unfathomable power? #speaker:Graciana #mood:think

It is not exactly unheard of for beings to bestow their power on beings lesser than themselves, however, I am unsure of the disparity... #speaker:Morgan #mood:neutral
Unlikely, but not out of the question. I certainly would not mind having access to his extraordinary cosmic abilities. #speaker:Morgan #mood:happy

 I know they can appear in multiple places and change form, but what else can O'Ryan do? #speaker:Graciana #mood:think

Well, I'm unsure of everything they can do, but I've heard O'Ryan can turn themself into a blackhole that consumes entire galaxies into his body... Certainly useful... #speaker:Morgan #mood:neutral

...Useful...Yeah... #speaker:Graciana #mood:sad
Can you please make sure they don't do that to my galaxy though? I prefer not to live inside of their belt for the rest of my life. #speaker:Graciana #mood:neutral

 Fair enough, although I'm sure in my current state neither one of us would even notice the difference. #speaker:Morgan #mood:happy
 
 Alrighty then, moving on. #speaker:Graciana #mood:neutral

->GoodContinued
*[Do the dirty work themself?]

Maybe O'Ryan would do the dirty work themself? #speaker:Graciana #mood:think

It would be strange if they did. #speaker:Morgan #mood:neutral
Even though I am far weaker than I once was, I should still be more than enough to be considered a powerful ally... #speaker:Morgan #mood:sad

 Right, but isn't O'Ryan made up of multiple galaxies and stuff? #speaker:Graciana #mood:think
 Doesn't that make them like, a god level threat, since they control the existence of probably a couple trillion people or something? #speaker:Graciana #mood:think
 
 Perhaps... #speaker:Morgan #mood: neutral
 I would be confused on why they would even help me reclaim my throne, instead of taking it for themself, if it was that simple for them... #speaker:Morgan #mood:neutral
 
Good point. #speaker:Graciana #mood:neutral
It's pretty hard to understand what goes on in that Void's head most of the time anyways, so until they show signs of the worst, expect the best I guess? #speaker:Graciana #mood:think

I will still have to plan for the worst just in case, but I am somewhat optimistic about their indifference being a large factor in coming to my aid. #speaker:Morgan #mood:neutral

Either way, this is a huge win Morgan! #speaker:Graciana #mood:happy

Indeed... #speaker:Morgan #mood:neutral
The battle has yet to be won, however the sun seems to be rising upon a new era once more. #speaker:Morgan #mood:neutral

->GoodContinued
*[Make a deal?]

Maybe O'Ryan wants to make some sort of deal with you? #speaker:Graciana #mood:think
 
While it is true most beings of tremendous power can and will make deals with creatures lesser than them, it is rare for one to make a deal with a being closer to their own power. #speaker:Morgan #mood:neutral
It would be unusual to say the least, but I also am not sure just how powerful O'Ryan is.
It appears they can travel seamlessly throughout the universe without issue, and is composed of multiple galaxies fueling their body. #speaker:Morgan #mood:think
But I have never seen or heard of them outside rumors, and their branching out to the food industry is rather unusual for a Voidspawn. #speaker:Morgan #mood:neutral

Oh yeah? What kind of rumors happened before they became a diner owner? #speaker:Graciana #mood:think

Since you work beneath them, I fear anything I say could directly cause you to change careers which would lead to these conversations ending, so I shall refrain from telling you for now. #speaker:Morgan #mood:sad
Roger that message was received loud and clear. #speaker:Graciana #mood:neutral

->GoodContinued
==GoodContinued==
~convo_numberOR+=1
~convo_numberM+=1
~affectionOR+=1

I do have to ask, though... #speaker:Graciana #mood:neutral
What would you do after you regain your power? #speaker:Graciana #mood:think
Well, I would pick up from where I left off, continue my reign, and rule over the passed souls of the dead for all eternity. #speaker:Morgan #mood:neutral
Perhaps add a few more vacations and time off to see the worlds and universes far and wide. #speaker:Morgan #mood:happy
But once I return to my throne, I want to destroy the void--Allow the universe to see its birthplace. And get a fresh view. No inky blackness every day, just a starry-filled space slowly passing by. #speaker:Morgan #mood:happy
I will miss my freedom as someone always must be on the throne, to maintain the natural balance of order in the collection and passing on of souls... #speaker:Morgan #mood:sad
But perhaps this time I will try talking to them more, and learning about their short but interesting lives. #speaker:Morgan #mood:neutral
Maybe I will even learn a thing or two from them, such as I have with you, Graciana. #speaker:Morgan #mood:happy
Hey now, I'm still very much in the flesh for the moment. #speaker:Graciana #mood:angry
But I appreciate that, and think all mentioned desires sound wonderful for you! #speaker:Graciana #mood:happy
I hope you can still visit and stop by every now and then, I'll miss my favorite Goddess. #speaker:Graciana #mood:happy
WAIT, If I pray to you or something, does that mean we can talk over long distance? #speaker:Graciana #mood:think
Like an old fashioned occult version of phone service? #speaker:Graciana #mood:happy
Hah... #speaker:Morgan #mood:happy
Hahahaha!#speaker:Morgan #mood:happy
You would make a wonderful jester my dear, but I had not thought about that. #speaker:Morgan #mood:happy
If I do regain my position on the throne and reclaim my title as Queen of the Damned, like any other being I have worked with in the past, you would be able to reach out to me through prayer and communion. #speaker:Morgan #mood:neutral
Would seances work too? I think I still have some candles and a board from when I was younger... #speaker:Graciana #mood:think
Oh? Worshiped Eldritch beings before me now, have we? #speaker:Morgan #mood:neutral
 More like trying to see if anyone or anything was out there, but no not really. It ended up being an awkward hour or me holding my hand on a board with nothing moving #speaker:Graciana #mood:happy
 Well perhaps I can use that as a way to stay in touch, even after I go back home. #speaker:Morgan #mood:happy
 One way or another you have provided me with a great service that I shall not forget Graciana, and for that you have my thanks. #speaker:Morgan #mood:happy

Please, allow me to express my gratitude in a way that a Human such as yourself would appreciate. #speaker:Morgan #mood:happy

(Morgan reaches out her hand...) #speaker:Graciana
(And pulls out an insanely fat stack of cash!) #speaker:Graciana #mood:money
O-oh, wow, uh, this is a lot! I don't know if I--

Nonsense, dear. The service you have given me is worth even beyond this currency. #speaker:Morgan
Please, accept it as a--

<i>(CRACK!)<i> #bgm:none

!!! #speaker:Graciana #mood:fear
(Her hand just popped clean off?!)

... #speaker:Morgan #mood:neutral
Oh dear.
I suppose I am rather on the elder side, hahah! #speaker:Morgan #mood:happy #bgm:dinDay

A-are you okay?! #speaker:Graciana

Yes my dear, I am fine. This occurs from time to time. #speaker:Morgan
You can simply take your tip out of the hand, I can regenerate a new one in no time.

O-oh, uh, okay... #speaker:Graciana #mood:neutral
Hm... #speaker:Graciana #mood:think #pu:mhand
(The hand is shut so tightly... I can't even slide the money out...) #speaker:Graciana #mood:sad

Ah, yes, I suppose the rigor mortis is setting in. #speaker:Morgan #pd: 
Feel free to take my hand with you, it should come loose eventually.

R-right... #speaker:Graciana #mood:neutral

In any case, I shall be off. #speaker:Morgan
Thank you once again for all you have done for me, Graciana. #speaker:Morgan #mood:happy

Of course! #speaker:Graciana #mood:happy
So long, Morgan! #esfo: 

->END
==MorganBadEnding==
Is O'Ryan offering themself as a sacrifice for you to regain power? #speaker:Graciana #mood:think

Perhaps they are offering themself as sacrifice for my rebirth. #speaker:Morgan #mood:happy

It is a rare offer to see in most beings as it means the end for one so another can live on a new, a very stupid notion for the one that dies. #speaker:Morgan #mood:think

But if they are willing to offer themself for my sake, I am willing to receive this gift with open arms. #speaker:Morgan #mood:neutral

Hey now, there's no reason in my mind that they would willingly do this after meeting you for mere, what? Minutes? Seconds? #speaker:Graciana #mood:neutral

I believe we conversed for a minute exactly before he departed. #speaker:Morgan #mood:neutral

Damn them and their short but precise timing. #speaker:Graciana #mood:angry

Well, what else could they have meant by this?#speaker:Graciana #mood:think

There is no other way I can see it in my mind, as one Eldritch being to another. #speaker:Morgan #mood:neutral

But what about the Diner, and my job, and all of their customers. Without O'Ryan everything falls apart, I don't know if this is a good idea...  #speaker:Graciana #mood:neutral

You said you would be willing to do anything to help me and see me return to power, yes? #speaker:Morgan #mood:angry 

Would you not want to see me happy, Graciana? #speaker:Morgan #mood:neutral

Well... Yes, I do... #speaker:Graciana #mood:fear
It just doesn't make sense to me. #speaker:Graciana #mood:think

Well, rationalize it for yourself and maybe we can walk through this together, before they arrive. #speaker:Morgan #mood:neutral

Well... #speaker:Graciana #mood:neutral

*[The Diner is a con?]

Maybe this was some sort of long con operation, to make this diner chain successful and retire for a life of convenience after giving all of their power over to someone else to run it for them? #speaker:Graciana #mood:think

Even if that is the case, I have no intention to run this business once they are gone, so they will have to deal with that aspect of their life without their power. #speaker:Morgan #mood:neutral

Right... I assume we would all be out of jobs then, without him... #speaker:Graciana #mood:neutral

I would have to go back to job hunting on Earth... #speaker:Graciana #mood:think 

Fear not my dear, once I gain O'Ryan's power I will leave you enough coin to support yourself for eons, for the great services you have provided me. #speaker:Morgan #mood:happy

Really? #speaker:Graciana #mood:neutral

But of course! It would be insulting for me to not take care of those who have taken care of me. #speaker:Morgan #mood:neutral

Well thank you, that means a lot Morgan. But I do prefer the work. #speaker:Graciana #mood:neutral
Without work, I am nothing, and when I am nothing, I get all weird and sad. #speaker:Graciana #mood:neutral

->BadContinued
*[Maybe they won't die?]

Maybe O'Ryan won't actually die, but just lose some of their strength? #speaker:Graciana #mood:think

That is more likely for a creature of their stature, with O'Ryan's current power they would not die for sharing even 90% of what they currently hold within themself. #speaker:Morgan #mood:neutral

Oh, well that's good news. He could just look after the diner even if they don't have Eldritch strength, right? #speaker:Graciana #mood:think

Of course! They would have to find a new way to get around the universes, but besides that nothing else should impair O'Ryan's business empire. #speaker:Morgan #mood:neutral

Besides a hostile takeover from a powerful being who seeks to take their business in its weakened state, perhaps. #speaker:Morgan #mood:neutral

Why would you even suggest that?! What if that happens now?! #speaker:Graciana #mood:angry

Oh my dear, your species has always held onto the belief of saying something out loud causing it to happen. #speaker:Morgan #mood:neutral

It's just not true, I have wished for the downfall of many who were both weak and strong and it only happened when I took action. #speaker:Morgan #mood:neutral

Keep that in mind when you are looking towards your future in O'Ryans employment. #speaker:Morgan #mood:neutral

Right... #speaker:Graciana #mood:neutral



->BadContinued
*[O'Ryan's just lost it...]

Maybe O'Ryan just lost their mind finally, after working in and being lost in their own void for eons. #speaker:Graciana #mood:think

Whether that means they'll give up their empire or not through logic and clarity of mind does not change my goals. #speaker:Morgan #mood:neutral

Although, it does lead me to question if I could get more than just his power, if he has lost his sanity... #speaker:Morgan #mood:neutral

Hey now, let's not kick dead horses.  #speaker:Graciana #mood:neutral

Is that an actual saying, or did you make that up just now? #speaker:Morgan #mood:think

I just made it up I panicked and tried to make something related to your whole theme I apologize please don't turn me into a cat-- #speaker:Graciana #mood:fear

Oh my dear, we are far past the cat jokes now; fear not, it was relevant and funny. I think I will make note of that for the future. #speaker:Morgan #mood:happy

(Oh Gods, what I have done...) #speaker:Graciana #mood:fear


->BadContinued
==BadContinued==
~convo_numberOR+=1
~convo_numberM+=1
~affectionOR-=1


Just remember, please try not to outright kill O'Ryan, even if they're offering themself as some sort of battery for you to drain. #speaker:Graciana #mood:neutral

Oh that is a good example, you are excellent at this Graciana! #speaker:Morgan #mood:neutral

I appreciate the kind words, but not the time to be complementing one another. #speaker:Graciana #mood:happy

Now, can we go over everything we've talked about over the past few days we've talked together? #speaker:Graciana #mood:think

All of the "friendship" talks, the "bettering yourself" talks, all of the "happiness matters" talks, combined into one. #speaker:Graciana #mood:neutral
"It's good to help yourself but maybe not destroy everything else around you" talk? #speaker:Graciana #mood:neutral

I don't remember that last part... #speaker:Morgan #mood:neutral

It's normally implied, but for you it totally makes sense to not be. #speaker:Graciana #mood:neutral

Right, an attempt will be made then, upon my throne being reclaimed. #speaker:Morgan #mood:neutral

Morgan. #speaker:Graciana #mood:neutral

Graciana. #speaker:Morgan #mood:neutral

In case this is the last time we do get to speak with one another, I just want you to know it has been a genuine pleasure getting to know you. #speaker:Graciana #mood:happy

Eldritch horror aside, you are a very interesting and wonderful being. #speaker:Graciana #mood:neutral

And I hope this power does not change that. #speaker:Graciana #mood:neutral

My dear, nothing could ever change what you have done for me and how I feel about my new but trusted friend. #speaker:Morgan #mood:happy

Alright then, that makes me feel slightly better about this... #speaker:Graciana #mood:neutral

Just like your wise man once said, A new day is upon us and then so a new dawn greets our vision. #speaker:Morgan #mood:neutral

Was that the actual quote? #speaker:Graciana #mood:think

Of course, has it changed in recent history? #speaker:Morgan #mood:neutral

Nevermind... #speaker:Graciana #mood:sad

Good luck Morgan, I hope the throne fits you better now. And that you stay in touch somehow or at least maybe talk to some of the departed souls every now and then. #speaker:Graciana #mood:neutral

That I shall, Farewell Graciana. #speaker:Morgan #mood:neutral

Farewell, Morgan. #speaker:Graciana #mood:neutral #scg:black

... #ss:Morgan:blank
//background change to night once those are implemented

It's getting kinda late... #speaker:Graciana #mood:neutral #ecg: 
(I hear that familiar sound of the portal activating, and O'Ryan steps through.) #ss:spotlight:O'Ryan:neutral

... #speaker:O'Ryan

O-oh, hi O'Ryan...! #speaker:Graciana #mood:neutral

... #speaker:O'Ryan
<i>(sniff)</i> #speaker:O'Ryan #mood:sad

(Suddenly, all the lights in the diner go out...!) #speaker:Graciana #mood:fear #bgm:none #scg:black

... #speaker:O'Ryan
U-uh... #speaker:Graciana #ss:spotlight:Morgan:angry

Hah... Hah... #speaker:Morgan #mood:angry
AHAHAHAHAHAHAHAHAHAHA!
YESSSS, THE TIME IS NOW! O'RYAN, COME TO ME! #speaker:Morgan #mood:angry

GRANT ME WHAT IS MINE, RELINQUISH ONTO ME YOUR STRENGTH SO I MAY RULE THE VOID ONCE MORE! #speaker:Morgan #mood:angry

(Morgan dives into O'Ryans stomach, and the galaxies inside twinkle out of existence one by one...) #speaker:Graciana #mood:fear

(O'Ryan stands completely still as the life is slowly sapped out...) #speaker:Graciana

... #speaker:O'Ryan
Graciana...
...
Be in work early tomorrow. Swatts needs help with inventory. 

(The second they finish their sentence, O'Ryan explodes into thousands upon thousands of small twinkling partices, that twinkle and fade out of existence...) #speaker:Graciana #mood:fear

MINEEEEEEEEEEEEEEEEEE FINALLY MMMMIIIIIINNNNNEEEEEEEEEEEEEEEEEEE!!!! #speaker:Morgan #mood:angry #ecg: 

I CAN FEEL THE STRENGTH SURGING THROUGH ME!! #speaker:Morgan #mood:angry

GRACIANA, I WILL TAKE WHAT YOU SAID TO HEART. SETTLING FOR HAPPINESS IN MY CURRENT STATE WOULD BE AN INSULT TO MYSELF. #speaker:Morgan #mood:angry

THE THRONE IS NOT ENOUGH NOW I WISH TO SIT ABOVE ALL CREATURES, ALL UNIVERSES, THE VOID SHALL NOT CONTAIN ME ANY LONGER! #speaker:Morgan #mood:angry

FROM THIS DAY FORWARD I, THE MORGAN, GODDESS OF NOT JUST THE DEPARTED, BUT NOW THE LIVING AND THE DEAD WILL RULE FOR ETERNITY OVER ALL KINGDOMS. #speaker:Morgan #mood:angry

AHAHHAHAHAHAHHAHAHAHHAHHAHAHHA! #speaker:Morgan #mood:angry

Oh, and here is your tip, dear. #speaker:Morgan #mood:happy

AHAHAHHAHAHHAHAHAHHAHHA! #speaker:Morgan #mood:angry

(The Morgan's form vanishes into smoke, leaving me alone in the diner confused and terrified.) #speaker:Graciana #mood:fear #ss:Morgan:blank

What have I just unleashed upon the universe...?
What have I done...? 
O'Ryan... I am so sorry... #speaker:Graciana #mood:sad
...

... #speaker:O'Ryan #mood:blank #bgm:dinNight

...Huh? #speaker:Graciana
...Where...?

... #speaker:O'Ryan
Apology accepted.
Now get back to work.

... #speaker:Graciana #mood:think
This diner makes no sense anymore... #speaker:Graciana #mood:sad #esfo: 

->END
==MorganChaosEnding==
I think that means O'Ryan wants you as a partner! #speaker:Graciana #mood:happy

Come again? #speaker:Morgan #mood:neutral

That sounds similar to how my people offer themselves awkwardly into a romantic partnership... 
(Or least how I've seen it portrayed in shows...) #speaker:Graciana #mood:neutral
 Maybe they are offering themself as both an ally and a partner? #speaker:Graciana #mood:think
 
... #speaker:Morgan #mood:neutral
Do you think this could be true? Even if it was, what would it entail? Would we live together for the rest of eternity? #speaker:Morgan #mood:neutral
Have voidlings? I'm not sure I am ready for a commitment like that to a being I have spoken to just once!

So you are saying you aren't interested in O'Ryan? I mean I get the scared part, but it seemed like before you were keeping tabs earlier. #speaker:Graciana #mood:think

 In a totally normal stalking routine to keep tabs on my enemies... #speaker:Morgan #mood:neutral
 Yes! #speaker:Morgan #mood:angry
 
 Just for keeping tabs? #speaker:Graciana #mood:think 
 (Hehe, Goddess of Death got boy problems, this is definitely going into my journal entry tonight.)
 
 Of course! I mean, how would it even work between us? #speaker:Morgan #mood:neutral
 One is a voidspawn and one the previous ruler of the void. #speaker:Morgan #mood:sad
 
 That means they would have been one of my subjects at some point in time... #speaker:Morgan #mood:neutral
 
 Ah yes, the classic "royalty falls in love with the common man-shaped-void-creature" trope. #speaker:Graciana #mood:happy
 
 This is a common occurance on your world? #speaker:Morgan #mood:neutral
 
 Surprisingly, more common than you would think. #speaker:Graciana #mood:think
 
 Interesting, perhaps my exposure to your world has influenced me to feel the same as the ones you described just now--Royals falling for their subjects. #speaker:Morgan #mood:neutral
 
 I mean think of it this way, with no crown to your name right now, technically you're now both on equal footing, which means now is the perfect time to explore any curiosities you might have towards them. #speaker:Graciana #mood:think
 (Playing wingwoman to a Goddess of Death should definitely go on my resume after this...) #speaker:Graciana #mood:think
 I'm just saying, there are few ways you could go about this to find out if they really like you. #speaker:Graciana #mood:happy
 
 Such as? #speaker:Morgan #mood:neutral


*[Ask directly!]

 You could always ask them directly, y'know? Just walk up and say "hey you beautiful voidling you, wanna be my life partner?" #speaker:Graciana #mood:happy
 
 Just like that? #speaker:Morgan #mood:neutral
 
 Just like that. #speaker:Graciana
 
 How many times have you seen this strategy work? #speaker:Morgan #mood:neutral
 
 Many times. #speaker:Graciana
 Has it worked, personally? #speaker:Morgan #mood:happy
 
 Ouch, uh, I don't really date at the moment because I lack time and resources to do so... #speaker:Graciana #mood:sad
 
 But have you seen this work with others? #speaker:Morgan #mood:neutral
 
 Absolutely. #speaker:Graciana #mood:happy
 
 You are sure this is not one of those program viewings you watch on Earth that is telling you this? #speaker:Morgan #mood:neutral
 
 ... #speaker:Graciana #mood:neutral
 I mean partially, BUT my Uncle did propose to my Aunt that way. #speaker:Graciana #mood:think
 
 And she said yes? #speaker:Morgan #mood:neutral
 
 Well no, it took like six tries, but she eventually said yes. #speaker:Graciana #mood:think
 
 Graciana, most of your advice has been sound. #speaker:Morgan #mood:neutral 
 
 Mhm. #speaker:Graciana #mood:happy
 
 This one, I am not sure of. #speaker:Morgan #mood:neutral
 
 Right... #speaker:Graciana #mood:neutral
 
 If your source is scripted events to cause dramatic emotions to be felt by a consumer, I am not sure that has applicable actions in the real world. #speaker:Morgan #mood:sad
 
 ...I mean, I was basing it off of some real events to be fair... #speaker:Graciana #mood:think
 

->ChaoticContinued
*[Make the first move!]
 
 You could... Make the first move! #speaker:Graciana #mood:happy
 
 What would that entail? #speaker:Morgan #mood:neutral
 
 Kiss 'em. #speaker:Graciana #mood:happy
 
 ... #speaker:Morgan #mood:neutral
 
 What? #speaker:Graciana #mood:happy
 
 Come again? #speaker:Morgan #mood:sad
 
 Kiss 'em right on the cosmo filled face. #speaker:Graciana #mood:happy
 
 Surely you jest. #speaker:Morgan #mood:neutral
 
 Jest, I do not. #speaker:Graciana #mood:happy
 
 Stop it. #speaker:Morgan #mood:angry
 
 Yes ma'am. #speaker:Graciana #mood:fear
 
 I am not sure such a intense first step would be a wise one, there are many factors that could cause this to be seen as an act of violence #speaker:Morgan #mood:neutral
 
 What if they think I'm trying to tear their face off to consume it, or consume one of the galaxies within their face, or just consume all of them? #speaker:Morgan #mood:sad
 
 I guess... #speaker:Graciana #mood:think 
 (I wanna make a "consuming" joke so bad but hearing the polite and fancily spoken Morgan say "stop..." It scares me.) #speaker:Graciana #mood:sad

->ChaoticContinued
*[Write a love letter!]

If you're too shy to say it... #speaker:Graciana #mood:think
You could write a love letter! #speaker:Graciana #mood:happy

 Huh? #speaker:Morgan #mood:neutral
 You know, a love letter! Something where you put everything on the line and just write down your feelings for someone, in hopes it reaches them and they respond in the same way! #speaker:Graciana #mood:happy
 
 I think I have seen this in some of my followers before... #speaker:Morgan #mood:sad
 They left blood-soaked letters of passion for me when they tried to summon me to the mortal planes. #speaker:Morgan #mood:neutral
 
 I have so many questions... #speaker:Graciana #mood:think
 One, did it work? Two, your followers actually hit on you through blood letters? And three...
 Huh?!?! #speaker:Graciana #mood:fear
 
 Well the Earth phrase of "flirting with death" has many meanings, that is one of them. But no, I never found them to be enough. #speaker:Morgan #mood:neutral
 Most were just sad men, looking for anyone or anything to talk to... #speaker:Morgan #mood:sad
 So I would just send cats to them instead, and they would be fine. #speaker:Morgan #mood:happy
 
 Do you have control over cats or something? #speaker:Graciana #mood:happy
 
 Partially, they are a lesser Eldritch being than I, so most obey my commands if it follows in line with their own goals. Most of which is causing chaos or mayhem, and getting scratched on the belly. #speaker:Morgan #mood:happy
 
 Interesting, but juicy new lore aside, do you think you would be interested in something like this? #speaker:Graciana #mood:think
 
 I'm not sure, it seems too new of a trend for me to take part in. #speaker:Morgan #mood:sad
 
 Oh yeah, you both lived for a long time before this. #speaker:Graciana #mood:think
 Ummmm, let me think... #speaker:Graciana #mood:think


->ChaoticContinued
==ChaoticContinued==
 Hm... #speaker:Morgan #mood:neutral
 The art of showing the hint of romantic intent, but not directly showing my feelings or actions until I can further tell whether or not they share them, is... Interesting. #speaker:Morgan #mood:neutral
 It seems foolproof, but how do I accomplish this? #speaker:Morgan #mood:sad
 
 Similar to "Option B" of asking them to be yours directly, you could simply ask them to go on this date to get dinner, or go see a part of history together, or gaze at blackholes, or whatever interests Eldritch Beings. #speaker:Graciana #mood:think
 And if they say yes, then that shows they're interested and you can ask them after the date is done to see if they like you or not... 
 And if it goes bad, you can chalk it up to a night out with a friend. #speaker:Graciana #mood:happy 
 
 Your wisdom is truly unexpected for your age, but pleasantly so. #speaker:Morgan #mood:happy
 Why thank you, I have watche-- #speaker:Graciana #mood:happy
 I mean, seen much in my short life so far. #speaker:Graciana #mood:fear
 Anyways I think it is worth a shot, especially because you could accomplish all your goals at once with them in this way. #speaker:Graciana #mood:happy
 Life partner, someone who can help you get back your power, and someone to help you grow as a person and challenge you to be better. #speaker:Graciana #mood:neutral
 
 I would hope O'Ryan would not challenge me if we were to be wed... #speaker:Morgan #mood:neutral
 
 No no no, like, make you try new things to become a better and even more interesting person then you are now. #speaker:Graciana #mood:neutral
 I know it's hard to believe since you're already such an amazing Goddess. #speaker:Graciana #mood:happy
 
 Your flattery is appreciated, my friend. #speaker:Morgan #mood:happy
 So, what activity should I ask O'Ryan to partake in with me? #speaker:Morgan #mood:neutral

*[Watching the stars.]

You could maybe ask them on a date to the edge of the universe, and watch the stars together... #speaker:Graciana #mood:happy

 That would not be the worst experience in the world, I admit despite my many travels and long life, I don't believe I've done this before. #speaker:Morgan #mood:neutral
 It sounds peaceful. Simple, but enjoyable. #speaker:Morgan #mood:happy
 I like it, but I fear O'Ryan being a voidling made of galaxies and stars themself... It may be redundant, no? Would they really enjoy such an activity? #speaker:Morgan #mood:sad
 
 You won't know 'til you try right? All you gotta do is ask, and if not you can suggest something else.  #speaker:Graciana #mood:think
 
 Perhaps you are correct, it is worth the attempt over sitting idle in anticipation. #speaker:Morgan #mood:neutral
 
 There you go, that's the spirit! #speaker:Graciana #mood:happy
 
 And you might even see a blackhole or two while you're stargazing! #speaker:Graciana #mood:happy
 
 That would be quite an profound sight for our first date. #speaker:Morgan #mood:neutral
 Oh my, I believe I just experienced shivers when that phrase came out of my mouth #speaker:Morgan #mood:happy
 Is this what you normally feel when faced with this kind of event? #speaker:Morgan #mood:neutral
 
 Exactly like that! #speaker:Graciana #mood:happy 
 Well, hopefully it's related to O'Ryan and not some random problem springing up. #speaker:Graciana #mood:neutral
 
 Why would you say that? What if it is? I could be draining my power and very life essence! #speaker:Morgan #mood:angry
 
 (OH GODS WHAT HAVE I DONE?!) I am so sorry Morgan I didn't mean it like that! #speaker:Graciana #mood:fear
 I really meant it as an internal thought but it came out loud, but I'm sure you're fine you're basically immortal, right? Right? #speaker:Graciana #mood:fear
 
 ...My humor causing you to squirm in confusion and discomfort makes my days more and more enjoyable! #speaker:Morgan #mood:happy
 
 ...And I love your laugh, even though it comes at the cost of my sanity... #speaker:Graciana #mood:fear
 (Hide the tears Graciana, Hide the tears...)#speaker:Graciana #mood:sad
 
 A small price to pay, to hear such a rare occurrence. #speaker:Morgan #mood:happy
 
 Mhm... #speaker:Graciana #mood:neutral



->Chaotic
*[Fine dining!]

You could invite them out to fine dining! At a fancy restaurant! #speaker:Graciana #mood:happy

 Oh, I know just the place! In my search for the finest sugary treats I found a restaurant that overlooks the Andromeda Galaxy.#speaker:Morgan #mood:happy
 
 Fantastic! You can take 'em there, wine and dine, and finish off with some sugary treats! #speaker:Graciana #mood:happy
 
 Hmmm, this does sound like a decent idea #speaker:Morgan #mood:neutral
 Perhaps I shall endeavor to invite them on this trip to the stars soon, so that we might share a night of personal discourse, and test the waters for any strong feelings #speaker:Morgan #mood:happy
 
 Sounds like the perfect plan, you can ask them when they stop by all their stores in the evening. I think they do a few others after this one...? #speaker:Graciana #mood:think
 
 It is quite alright, I know which one O'Ryan frequents around this time. #speaker:Morgan #mood:neutral
 
 And that information is perfectly normal! #speaker:Graciana #mood:happy
 Of course! #speaker:Morgan #mood:happy
 ... #speaker:Graciana #mood:neutral
 ... #speaker:Morgan #mood:neutral
->Chaotic
*[Explore somewhere new!]

The two of you could go explore somewhere new together! Somewhere neither of you have ever been! #speaker:Graciana #mood:happy

 Is there even such a place? I have viewed this universe for eons and have seen almost every planet, star, and living being upon them, #speaker:Morgan #mood:neutral
 
 Well, yes, but with O'Ryan they could take you to new universes, right? Ones you would never dream of seeing? If that is your dream.... #speaker:Graciana #mood:neutral
 Do you dream? #speaker:Graciana #mood:think
 
 You have a fascinating way of spilling out all your thoughts from your mouth without ever thinking about, them don't you? #speaker:Morgan #mood:happy
 
 Yes ma'am! #speaker:Graciana #mood:fear
 
 Well, most of those ideas do happen to be useful, so I can't complain all that much. #speaker:Morgan #mood:neutral
 
 Why thank you ma'am. #speaker:Graciana #mood:happy
 
 I will flick your nose and turn you into a cat the next time you call me ma'am! #speaker:Morgan #mood:angry
 
 Yes ma-- #speaker:Graciana #mood:fear
 Righty 'o Morgan!
 
 There, much better. #speaker:Morgan #mood:happy
 Now, I am a little uneasy about going to a different universe or plane of existence that even my knowledge has not seen yet, but I guess it can be done for the sake of our date. #speaker:Morgan #mood:neutral
 
 That's the spirit! And plus, if it is too weird, you can always just go to a favorite place if you've found one since you left the void #speaker:Graciana #mood:neutral
 
 Not really. #speaker:Morgan #mood:neutral
 
 Welp, go with the flow and make good choices. #speaker:Graciana #mood:think
 That I shall. #speaker:Morgan #mood:neutral
    ->Chaotic

==Chaotic==
~convo_numberOR+=1
~convo_numberM+=1
~chaosOR+=1

Well, the  logical thing would be to gaze out into the stars, scout out worlds for our honeymoon, and then conquer those worlds. #speaker:Morgan #mood:neutral 

Honeymoon? #speaker:Graciana #mood:think

Well yes, I assume like any Eldritch being with a modicum of respect for themselves, that they would propose to me after a successful first date. #speaker:Morgan #mood:neutral

That quick?! #speaker:Graciana #mood:think

We <i>are</i> very simple beings at our core, we will know whether we will work as partners from the day we attempt to romance one another. #speaker:Morgan #mood:neutral
If it is meant to be, why waste time in reaching our goal of an eternity of harmonic existence? #speaker:Morgan #mood:neutral

Wow. That sounds almost pleasant. #speaker:Graciana #mood:think

Until both of us merge together to form a new Eldritch entity, that is capable of both its parents, and takes control of our current minds with all of the memories of us combined. #speaker:Morgan #mood:neutral

Oh my. #speaker:Graciana #mood:fear

Yes, it is a beautiful process. #speaker:Morgan #mood:happy

If that's what you want... #speaker:Graciana #mood:think

Indeed, it is. #speaker:Morgan #mood:happy

I wish you the best of luck, then. #speaker:Graciana #mood:happy

Thank you dear, I will try to visit as often as I can. #speaker:Morgan #mood:neutral

That, or send nightmares to you so we can speak when you are off work. #speaker:Morgan #mood:happy 

That's not necessary, but if you want to I physically can't stop you. #speaker:Graciana #mood:fear

Wonderful! #speaker:Morgan #mood:happy
Tah-tah my dear, I must go now. #speaker:Morgan #mood:neutral

Go get 'em Morgan! #speaker:Graciana #mood:happy #scg:black

...
...
...

(I haven't seen Morgan in a while...)
(O'Ryan hasn't been in much, either...)
(It's been like... What...)
(Six days? Six hours, and six minutes?)
(I'm worried... Did something happen?)
(...)
(Oh well... I gotta open up the Diner today, I guess...)
(Hm? The portal's already unlocked...) #ecg: 
...
...Morgan?! #speaker:Graciana #mood:fear

Hello, dear! #speaker:Morgan #mood:happy

Is that... #speaker:Graciana #mood:think
Is that a ring?! #speaker:Graciana #mood:happy 

(I guess there are some happy endings after all...)
(Even if this one is still kinda weird.) #esfo:

->END