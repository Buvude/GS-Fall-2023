INCLUDE globals.ink

//my mental breakdown aside, her character and arc is really good. the relationship between her and graciana is so fun and cool
//dom you're genuinely a phenomenal writer just PLEASE use spell check and follow my ink formatting more, i BEG OF YOU

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
I think today I will just have a slice of marble cake, with black fondant and red frosting in the shape of roses #speaker:Morgan #mood:happy

Oooo, such a specific and fancy request makes me think that something amazing has happened! What's the good news Morgan!?! #speaker:Graciana #mood:happy

The request had nothing to do with anything occurring outside the diner, I simply saw it in one of your Earth programs and it caught me eye. #speaker:Morgan #mood:neutral

Oh... #speaker:Graciana #mood:sad

But as you stated previously, something did happen. #speaker:Morgan #mood:neutral

I knew it! Tell me everything! #speaker:Graciana #mood:happy

Cake first, please. #speaker:Morgan #mood:neutral

Right, no that makes sense. #speaker:Graciana #mood:neutral
One second... #speaker:Graciana #mood:neutral #scg:black
...
Alright, tell me what happened! #speaker:Graciana #mood:happy #ecg: 

Well, you suggested I reached out to those around me, and for those who would like to help see me come to power, better myself, and all of the friendships benefits you listed previously... #speaker:Morgan #mood:think
 annndd? #speaker:Graciana #mood:happy
 I decided to meet with O'Ryan briefly, we talked for a few minutes outside one of his other establishments I saw he frequented on towards the afternoon #speaker:Morgan #mood:happy
 oooohhhhh, how did it go! #speaker:Graciana #mood:happy
 I discussed with him my goals and position, and how someone has been trying to get me to branch myself out to those around me to help me grow and create friendships #speaker:Morgan #mood:happy
 and what did he say! #speaker:Graciana #mood:happy
 a few words and a tip of his void filled hat as he left, you were right about his very short and to the point personality. #speaker:Morgan #mood:happy
 I am not quite sure on what to do about him at the moment. If I am to be completely honest, he is a bit of an enigma. #speaker:Morgan #mood:happy
He neither stated he would directly support me, nor be my friend, but I felt there was some kind of hidden meaning or message behind his words than I picked up on at first. #speaker:Morgan #mood:happy
Oh? like he said something in a secret message to not alert other gods of your talk? #speaker:Graciana #mood:happy
perhaps, but I believe it was more on the lines of he was leading me on to something, I just can not find what it is #speaker:Morgan #mood:happy
What exactly did he say? #speaker:Graciana #mood:happy
Well, we conversed in the ancient tongue of the gods so I don't know the exact translation to your language, but it would probably be somewhere around the lines of "You may have me if you wish" #speaker:Morgan #mood:happy
Oh my...  #speaker:Graciana #mood:happy

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
I think that means he is offering himself as an friend/ally #speaker:Graciana

 Really? Just like that, I ask for help and he would be willing to potentially throw the universe out of balance because I said please and thank you? #speaker:Morgan #mood:happy
 I mean did you say please and thank you #speaker:Graciana #mood:happy
 Yes it was disturbing for those words to be coming out of my mouth #speaker:Morgan #mood:happy
 I think I fell ill moments later#speaker:Morgan #mood:happy
 Oh boy, we will find another way for you to express nice things then  #speaker:Graciana #mood:happy
 Please do ................................. #speaker:Morgan #mood:happy
 ............................................ #speaker:Graciana #mood:happy
 .............................................. #speaker:Morgan #mood:happy
Are you ok? #speaker:Graciana #mood:happy
I fear you are changing me for the better and worse #speaker:Morgan #mood:happy
Lets try and avoid the worst part then #speaker:Graciana #mood:happy
But that's good news that he is willing to be a friend or ally or whatever you want to call him to restore you to power. Did he say how they were going to do it? #speaker:Graciana #mood:happy
Not a word, just that one phrase mixed with a hello and a good evening #speaker:Morgan #mood:happy
Wow they really do say next to nothing #speaker:Graciana #mood:happy
So how do you think he will go about it? #speaker:Morgan #mood:happy


**[Give you a boon of unfathomable power]

 It is not exactly underheard of for beings to bestow their power on beings lesser than themselves, however I am unsure the  disparity #speaker:Morgan #mood:happy
 Unlikely but not out of the question, I certainly would not mind having access to his extraordinary cosmic abilities #speaker:Morgan #mood:happy
 I know he can appear in places and change his form, but what else can he do? #speaker:Graciana #mood:happy
 Well I'm unsure of everything he can do, but I've heard he can turn himself into a blackhole that consumes entire galaxies into his body. Certainly useful #speaker:Morgan #mood:happy
 ...................... useful............yeah...................can you please make sure he doesn't do that to my galaxy though, I prefer not to live inside of his belt for the rest of my life.#speaker:Graciana #mood:happy 
 Fair enough, although I'm sure in my current state neither one of us would even notice the difference #speaker:Morgan #mood:happy
 Alrightly then moving on #speaker:Graciana #mood:happy
 I do have to ask though #speaker:Morgan #mood:happy



->GoodContinued
**[Do the dirty work himself]

 Well it would be strange if he did, even though I am far weaker than I once was I should still be more than enough to be#speaker:Graciana #mood:happy considered a powerful ally #speaker:Morgan #mood:happy
 Right, but isn't he made up of multiple galaxies and stuff? 
 Doesn't that make him like a god level threat since he controls the existence of probably a couple one hundred billion peoples or something #speaker:Graciana #mood:happy
 Perhaps, I would be confused on why they would even help me reclaim my throne then instead of taking it for himself if it was that simple for them #speaker:Morgan #mood:happy
 Good point #speaker:Graciana #mood:happy
 It's pretty hard to understand what goes on in that Void's head most of the time anyways, so until he shows signs of the worst expect the best I guess? #speaker:Morgan #mood:happy
 I will still have to plan for the worse just in case, but I am somewhat optimistic about his indifference being a large factor in him coming to my aid #speaker:Morgan #mood:happy
 Either way this is a huge win Morgan! #speaker:Graciana #mood:happy
 Indeed, the battle has yet to be won, however the sun seems to be rising upon a new era once more #speaker:Morgan #mood:happy



->GoodContinued
**[Make some sort of deal]
 
 While it is true most beings of tremendous power can and will make deals with creatures lesser than them, it is rare for one to make a deal with a being closer to their own  #speaker:Morgan #mood:happy
 It would be unusual to say the least, but I also am not sure just how powerful O'Ryan is #speaker:Morgan #mood:happy
 It appears he can travel seamlessly throughout the universe without issues, and is comprised of multiple galaxies fueling his body #speaker:Morgan #mood:happy
 But I have never seen or heard of him outside rumors and his  obvious branching out to the food industry, which was a shock to most #speaker:Morgan #mood:happy
 Oh yeah? What kind of rumors happened before he became a diner owner? #speaker:Graciana #mood:happy
 Since you work beneath him I fear anything I say could directly cause you to change careers which would lead to these conversations ending, so I shall refrain from telling you for now #speaker:Morgan #mood:happy
 oh............ roger that message received loud and clear #speaker:Graciana #mood:happy

->GoodContinued
==GoodContinued==

 Well I would pick up from where I left off, continue my reign and rule over the passed souls of the dead for all eternity.#speaker:Morgan #mood:happy
 Perhaps add a few more vacations and time off to see the worlds and universes far and wide #speaker:Morgan #mood:happy
 But once I return to my throne I want to destroy the void, allow the universe to see its birthplace. And get a fresh view, no inky blackness every day, just a starry filled space slowly passing by. #speaker:Morgan #mood:happy
 I will miss my freedom as someone always must be on the throne to maintain the natural balance of order in the collection and passing on of souls. But perhaps this time I will try talking to them more, learning about their short but interesting lives#speaker:Morgan #mood:happy 
 Maybe I will even learn a thing or two from them, such as I have with you Graciana #speaker:Morgan #mood:happy
 Hey now Im still very much in the flesh for the moment #speaker:Graciana #mood:happy
 But I appreciate that, and think all mentioned desires sound wonderful for you #speaker:Graciana #mood:happy
 I hope you can still visit and stop by every now and then, I will miss my favorite Goddess #speaker:Graciana #mood:happy
 WAIT, If I pray to you or something does that mean we can talk over long distance #speaker:Graciana #mood:happy
 Like an old fashioned occult version of phone service? #speaker:Graciana #mood:happy
 ahahahahahahah AHAHAHAHAHAHA ahahahahaha #speaker:Morgan #mood:happy
 You would make a wonderful jester my dear, but I had not thought about that #speaker:Morgan #mood:happy
 If I do regain my position on the throne and reclaim my title as Queen of the Damned, it would make sense like any other being I have worked with in the past you would be able to reach out to me through prayer and communions #speaker:Morgan #mood:happy
 Would seances work too? I think I still have some candles and a board from when I was younger #speaker:Graciana #mood:happy
 Oh? Worshiped Eldritch beings before me now have we?
 More like trying to see if anyone or anything was out there, but no not really. It ended up being an awkward hour or me holding my hand on a board with nothing moving #speaker:Graciana #mood:happy
 well perhaps I can use that as a way to stay in touch, even after I go back home. #speaker:Morgan #mood:happy
 One way or another you have provided me with a great service that I shall not forget Graciana, and for that you have my thanks. #speaker:Morgan #mood:happy
~GoToAppartment()

->END
==MorganBadEnding==
Is he offering himself as a sacrifice for you to regain power? #speaker:Graciana

Perhaps he is offering himself as sacrifice for my rebirth #speaker:Morgan #mood: neutral

It is a rare offer to see in most beings as it means the end for one so another can live on a new, a very stupid notion for the one that dies. #speaker:Morgan #mood: neutral

But if he is willing to offer himself for my sake I am willing to receive this gift with open arms #speaker:Morgan #mood: neutral

Hey now, there is no reason in my mind that he would willingly do this after meeting you for mere what? Minutes? Seconds? #speaker:Graciana #mood: neutral

I believe we conversed for a minute exactly before he departed #speaker:Morgan #mood: neutral

Dam him and his short but precise timing #speaker:Graciana #mood: neutral

Well what else could he have meant by this?#speaker:Graciana #mood: neutral

There is no other way I can see it in my mind as one Eldritch being to another #speaker:Morgan #mood: neutral

But what about the Diner, and my job, and all of his customers. Without him everything falls apart, I don't know if this is a good idea  #speaker:Graciana #mood: neutral

You said you would be willing to do anything to help me and see me return to power, yes? #speaker:Morgan #mood: neutral 

Would you not want to see me happy Graciana? #speaker:Morgan #mood: neutral

Well yes I do ...... it just doesn't make sense to me #speaker:Graciana #mood: neutral

Well rationalize it for yourself and maybe we can walk through this together before he arrives #speaker:Morgan #mood: neutral

Well...... #speaker:Graciana #mood: neutral

**[Maybe he built the diner chain for someone else to take over for him?]

Maybe this was some sort of long con operation, to make this diner chain successful and retire for a life of convenience after giving all of his power over to someone else to run it for him? #speaker:Graciana #mood: neutral

Well even if that is the case I have no intention to run his business once he is gone so he will have to deal with that aspect of his life without his power #speaker:Morgan #mood: neutral

right.... I assume we would all be out of jobs then without him #speaker:Graciana #mood: neutral

I would have to go back to job hunting on Earth...... #speaker:Graciana #mood: neutral 

Fear not my dear, once I gain his power I will leave you enough coin to support yourself for eons for the great services you have provided me #speaker:Morgan #mood: neutral

Really? #speaker:Graciana #mood: neutral

of course! It would be insulting for me to not take care of those who have taken care of me #speaker:Morgan #mood: neutral

well thank you, that means a lot Morgan. But I do prefer the work. Without work I am nothing and when i am nothing I am very sad #speaker:Graciana #mood: neutral

->BadContinued
**[Maybe he won't actually die but will just lose his strength?]

that is more likely for a creature of his stature, with his current power he would not die for sharing even 90% of what he currently holds within him #speaker:Morgan #mood: neutral

oh well thats good news, he could just look after the diners even if he does not have his Eldritch strength right? #speaker:Graciana #mood: neutral 

Of course! He would have to find a new way to get around the universes, but besides that nothing else should impair his business empire. #speaker:Morgan #mood: neutral

Besides a hostile takeover from a powerful being who seeks to take his business in his weakened state perhaps #speaker:Morgan #mood: neutral

Why would you even suggest that! What if that happens now! #speaker:Graciana #mood: neutral

Oh my dear, your specicies has always held onto the belief of saying something out loud causing it to happen. #speaker:Morgan #mood: neutral

Its just not true, I have wished the downfall of many who were both weak and strong and it only happened when I took action. #speaker:Morgan #mood: neutral

Keep that in mind when you are looking towards your future in O'Ryans employment #speaker:Morgan #mood: neutral

Right....... #speaker:Graciana #mood: neutral



->BadContinued
**[I dont know man maybe he is just crazy]

Maybe he just lost his shit finally after working in and being lost in his own void for eons #speaker:Graciana #mood: neutral

Whether that means he will give up his empire or not through logic and clarity of mind does not change my goals #speaker:Morgan #mood: neutral

Although it does lead me to question if I could get more than just his power if he has lost his sanity #speaker:Morgan #mood: neutral

Hey now, lets not kick dead horses  #speaker:Graciana #mood: neutral

Is that an actual saying or did you just make that up just now? #speaker:Morgan #mood: neutral

I just made it up I panicked and tried to make something related to your whole theme I apologize please don't turn me into a cat #speaker:Graciana #mood: neutral

Oh my Dear we are far past the cat jokes now, fear not it was relevant and funny. I think I will make note of that for the future #speaker:Morgan #mood: neutral

oh gods what I have done #speaker:Graciana #mood: neutral


->BadContinued
==BadContinued==

Just remember please try not to outright kill him even if he is offering himself as some sort of battery for you to drain #speaker:Graciana #mood: neutral

oh that is a good example, you are excellent at this Graciana #speaker:Morgan #mood: neutral

I appreciate the kind words but not the time to be complementing one another #speaker:Graciana #mood: neutral

Now, can we go over everything we have talked about over the past few days we have talked together #speaker:Graciana #mood: neutral

All of the friendship talks, the bettering yourself talks, all of the your happiness matters talks combined into one its good to help yourself but maybe not destroy everything else around you talk? #speaker:Graciana #mood: neutral

I don't remember that last part #speaker:Morgan #mood: neutral

That's on me it's normally implied but for you it totally makes sense to not be #speaker:Graciana #mood: neutral

Right an attempt will be made then upon my throne being reclaimed #speaker:Morgan #mood: neutral

Morgan #speaker:Graciana #mood: neutral

Graciana #speaker:Morgan #mood: neutral

In case this is the last time we do get to speak with one another I just want you to know it has been a genuine pleasure getting to know you #speaker:Graciana #mood: neutral

Eldritch horror aside you are a very interesting and wonderful being #speaker:Graciana #mood: neutral

And I hope this power does not change that #speaker:Graciana #mood: neutral

My Dear nothing could ever change what you have done for me and how I feel about my new but trusted friend #speaker:Morgan #mood: neutral

Alright then, that makes me feel slightly better about this #speaker:Graciana #mood: neutral

Just like your wise man once said, A new day is upon us and then so a new dawn greets our vision #speaker:Morgan #mood: neutral

Was that the actual quote? #speaker:Graciana #mood: neutral

Of course, has it changed in recent history? #speaker:Morgan #mood: neutral

Nevermind #speaker:Graciana #mood: neutral

Good luck Morgan, I hope the throne fits you better now. And that you stay in touch somehow or at least maybe talk to some of the departed souls every now and then #speaker:Graciana #mood: neutral

That I shall, Farewell Graciana #speaker:Morgan #mood: neutral

Farewell Morgan #speaker:Graciana #mood: neutral

//transition here im gonna do this don't worry this comment is just for myself
//i gotta do that like speaker replacement thingy

YESSSS THE TIME IS NOW O'RYAN COME TO ME #speaker:Morgan #mood: neutral

GRANT ME WHAT IS MINE, RELINQUISH ONTO ME YOUR STRENGTH SO I MAY RULE THE VOID ONCE MORE #speaker:Morgan #mood: neutral

(You watch as Morgan dives into O'Ryans stomach and the galaxies inside twinkle out of existence one by one) #speaker:Graciana #mood: neutral

(O'Ryan stands completely still as the life is sapped of him and slowly turns to look at you before saying "Be in work early tomorrow Swatts needs help with inventory" before exploding into a infinite amount of pieces of void that fizzle out of existence) #speaker:Graciana #mood: neutral

MINEEEEEEEEEEEEEEEEEE FINALLY MMMMIIIIIINNNNNEEEEEEEEEEEEEEEEEEE #speaker:Morgan #mood: neutral

I CAN FEEL THE STRENGTH SURGING THROUGH ME #speaker:Morgan #mood: neutral

GRACIANA, I WILL TAKE WHAT YOU SAID TO HEART. SETTLING FOR HAPPINESS IN MY CURRENT STATE WOULD BE AN INSULT TO MYSELF #speaker:Morgan #mood: neutral

THE THRONE IS NOT ENOUGH NOW I WISH TO SIT ABOVE ALL CREATURES, ALL UNIVERSES, THE VOID SHALL NOT CONTAIN ME ANY LONGER #speaker:Morgan #mood: neutral

FROM THIS DAY FORWARD I, THE MORGAN, GODDESS OF NOT JUST THE DEPARTED, BUT NOW THE LIVING AND THE DEAD WILL RULE FOR ETERNITY OVER ALL KINGDOMS #speaker:Morgan #mood: neutral

AHAHHAHAHAHAHHAHAHAHHAHHAHAHHA #speaker:Morgan #mood: neutral

Oh and here is your tip dear #speaker:Morgan #mood: neutral

AHAHAHHAHAHHAHAHAHHAHHA #speaker:Morgan #mood: neutral

(The Morgans form vanishes into smoke leaving you alone in the diner confused, terrified for what you have unleashed upon the universe) #speaker:Morgan #mood: neutral

What have I done.............. O'Ryan I am so sorry#speaker:Graciana #mood: neutral
....................... #speaker:Graciana #mood: neutral

(You hear a faint "Apology accepted now get back to work" from the surrounding space around you) #speaker:Graciana #mood: neutral

This diner makes no sense anymore............ #speaker:Graciana #mood: neutral
~GoToAppartment()

->END
==MorganChaosEnding==
I think that means he wants you as a partner #speaker:Graciana #mood:happy

Come again? #speaker:Morgan #mood:happy
That sounds very similar to how my people offer themselves awkwardly into a romantic partnership (or least how I have seen it portrayed in shows) #speaker:Graciana #mood:happy
 Maybe he is offering himself as both an ally and a partner? #speaker:Morgan #mood:happy #speaker:Graciana #mood:happy
..................................
 Do you think this could be true? But even if it was, what would it entail? Would we live together for the rest of eternity? Have voidlings? I'm not sure I am ready for a commitment like that to a man I have spoken to just once! #speaker:Morgan #mood:happy
 So you are saying you aren't interested in O'ryan? I mean I get the scared part but it seemed like before you were keeping tabs on him #speaker:Graciana #mood:happy
 In a totally normal stalking routine to keep tabs on my enemies #speaker:Morgan #mood:happy yes! #speaker:Morgan #mood:happy
 Just for keeping tabs? (hehe goddess of death got boy problems, this is definitely going into my journal entry tonight)  #speaker:Graciana #mood:happy
 Of course! I mean how would it even work between us, one is a voidspawn and one the previous ruler of the void. That means he would have been one of my subjects at some point in time #speaker:Morgan #mood:happy
 Ah yes, the classic royalty falls in love with the common man shaped void creature #speaker:Graciana #mood:happy
 This is a common occurance on your world? 
 More common than you would think #speaker:Graciana #mood:happy
 Interesting, perhaps my exposure to your world has influenced me to feel the same as the ones you described just now. Royals falling for their subjects #speaker:Morgan #mood:happy
 I mean think of it this way, with no crown to your name right now technically you are now both on equal footing, which means the perfect time to explore any curiosities you might have towards him (playing wingwoman to Morgan should definitely go on my resume after this) #speaker:Graciana #mood:happy
 I'm just saying there a few ways you could go about this to find out if he really likes you #speaker:Graciana #mood:happy
 Such as? #speaker:Morgan #mood:happy


**[Ask him directly]

 You could always ask them directly, you know just walk up and say hey you beautiful voidling you, wanna be my life partner? #speaker:Graciana #mood:happy
 Just like that? #speaker:Morgan #mood:happy
 Just like that #speaker:Graciana #mood:happy
 How many times have you seen this strategy work #speaker:Morgan #mood:happy
 Many times #speaker:Graciana #mood:happy
 Has it worked personally? #speaker:Morgan #mood:happy
 Ouch, um I don't really date at the moment because I lack time and resources to do so #speaker:Graciana #mood:happy
 But have you seen this work with others? #speaker:Morgan #mood:happy
 Absolutely #speaker:Graciana #mood:happy
 You are sure this is not one of those program viewings you watch on earth that is telling you this #speaker:Morgan #mood:happy
 ........................ I mean partially, BUT my uncle did propose to my aunt that way #speaker:Graciana #mood:happy
 And she said yes? #speaker:Morgan #mood:happy
 well no, it took like 6 tries but she eventually said yes 
 Graciana, most of your advice has been sound #speaker:Morgan #mood:happy 
 mhm #speaker:Graciana #mood:happy
 This one I am not sure of #speaker:Morgan #mood:happy
 right #speaker:Graciana #mood:happy
 If your source is scripted events to cause dramatic emotions to be felt by a consumer, I am not sure that has applicable actions in the real world #speaker:Morgan #mood:happy
 ..................... I mean I was basing it off of some real events to but fair #speaker:Graciana #mood:happy
 

->ChaoticContinued
**[Make the first move]
 
 What would that entail?
 Kiss em #speaker:Graciana #mood:happy
 .......................................
 What? #speaker:Graciana #mood:happy
 Come again? #speaker:Morgan #mood:happy
 Kiss em right on the cosmo filled face #speaker:Graciana #mood:happy
 surely you jest #speaker:Morgan #mood:happy
 Jest, I do not #speaker:Graciana #mood:happy
 stop it #speaker:Morgan #mood:happy
 yes mamm #speaker:Graciana #mood:happy
 I am not sure such a intense first step would be a wise one, there are many factors that could cause this to be seen as an act of violence #speaker:Morgan #mood:happy
 What if he thinks I'm trying to tear his face off to consume it, or consume one of the galaxies within his face, or just consume all of him? #speaker:Morgan #mood:happy
 I guess........... (I want to make a consuming joke so bad but hearing the polite and fancily spoken Morgan say stop it scares me) #speaker:Graciana #mood:happy

->ChaoticContinued
**[Write him a love letter]

 huh? 
 you know a love letter, something where you put everything on the line and just write down your feelings for someone in hopes it reaches them and they respond in the same way #speaker:Graciana #mood:happy
 I think I have seen this in some of my followers before, they left blood soaked letters of passion for me when they tried to summon me to the mortal planes. #speaker:Morgan #mood:happy
 I have so many questions, one did it work? two of your followers actually hit on you through blood letters? and three Huh!?!?! #speaker:Graciana #mood:happy
 Well the earth phrase of flirting with death has many meanings, that is one of them. but no I never found them to be enough. Most were just sad men looking for anyone or anything to talk to so I would just send cats to them instead and they would be fine. #speaker:Morgan #mood:happy
 You have control over cats? #speaker:Graciana #mood:happy
 Partially, they are a lesser Eldritch being than I so most obey my commands if it follows in line with their own goals. Most of which is causing chaos or mayhem and getting scratched on the belly #speaker:Morgan #mood:happy
 Interesting, but juicy new lore aside do you think you would be interested in something like this? #speaker:Graciana #mood:happy
 I'm not sure, it seems too new of a trend for me to take part in. 
 oh yeah, you both lived for a long time before this #speaker:Morgan #mood:happy
 ummmm, let me think #speaker:Graciana #mood:happy


->ChaoticContinued
==ChaoticContinued==
 interesting, showing the hint of romantic intent but not directly showing my feelings or actions until I can further tell whether or not they share them. #speaker:Morgan #mood:happy
 Seems foolproof, but how do I accomplish this? #speaker:Morgan #mood:happy
 Well similar to option b of asking him to be yours directly, you could simply ask him to go on this date to get dinner or go see a part of history together, or gaze at blackholes, or whatever interests you. #speaker:Graciana #mood:happy
 And if he says yes well that shows he is interested and you can ask them after the date is done to see if you like them or not, and if it goes bad you can chalk it up to a night out with a friend#speaker:Graciana #mood:happy 
 Your wisdom is truly unexpected for your age, but pleasantly so #speaker:Morgan #mood:happy
 Why thank you, I have watche- I mean seen much in my short life so far #speaker:Graciana #mood:happy
 Anyways I think it is worth a shot, especially because you could accomplish all your goals at once with him in this way. #speaker:Graciana #mood:happy
 Life partner, someone who can help you get back your power, and someone to help you grow as a person and challenge you to be better #speaker:Graciana #mood:happy
 I would hope he would not challenge me if we were to be wed #speaker:Morgan #mood:happy
 no no no, like make you try new things to become a better and even more interesting person then you are now. I know it's hard to believe since you are already such an amazing Goddess. #speaker:Graciana #mood:happy
 Your flattery is appreciated my friend #speaker:Morgan #mood:happy
 So what activity should I ask him to partake in with me?#speaker:Morgan #mood:happy

**[Sitting on the edge of the universe watching the stars]
 That would not be the worst experience in the world, I admit  despite my many travels and long life I don't believe I've done this before #speaker:Morgan #mood:happy
 It sounds peaceful, simple, but enjoyable #speaker:Morgan #mood:happy
 I like it, but I fear O'Ryan being a voidling made of galaxies and stars themself it would be redundant no? Would they really  enjoy such an activity? #speaker:Morgan #mood:happy
 You won't know till you try right? All you gotta do is ask and if not you can suggest something else  #speaker:Graciana #mood:happy
 Perhaps, you are correct it is worth the attempt over sitting idle in anticipation #speaker:Morgan #mood:happy
 There you go, that's the spirit! #speaker:Graciana #mood:happy
 And you might even see a black hole or two while your star gazing! 
 That would be quite an profound sight for our first date #speaker:Morgan #mood:happy
 Oh my I believe I just experienced shivers when that phrase came out of my mouth #speaker:Morgan #mood:happy
 Is this what you normally feel when faced with this kind of event? #speaker:Morgan #mood:happy
 Exactly like that, well hopefully its related to O'Ryan and not some random problem springing up #speaker:Graciana #mood:happy
 Why would you say that? What if it is, I could be draining of my power and very life essence #speaker:Morgan #mood:happy
 (OH GODS WHAT HAVE I DONE) I am so sorry Morgan I didn't mean it like that! I really meant it as an internal thought but it came out loud but I'm sure you're fine you're basically immortal right? Right? #speaker:Graciana #mood:happy
 My humor causing you to squirm in confusion and discomfort makes my days more and more enjoyable #speaker:Morgan #mood:happy
 And I love your laugh even though it comes at the cost of my sanity#speaker:Graciana #mood:happy
 (hide the tears Graciana, hide the tears)#speaker:Graciana #mood:happy
 small price to pay to hear such a rare occurrence #speaker:Morgan #mood:happy
 mhm #speaker:Graciana #mood:happy



->Chaotic
**[Fine dining at a restaurant overlooking the milky way]

 Oh I know just the place, in my search for the finest sugary treats I found a restaurant that does overlook the Andromeda Galaxy.#speaker:Morgan #mood:happy 
 Oh fantastic, you can take em there wine and dine and finish off with some sugary treats #speaker:Graciana #mood:happy
 Hmmm this does sound like a decent idea #speaker:Morgan #mood:happy
 Perhaps I shall endeavor to invite him on this trip to the stars soon, so that we might share in a night of personal discourse and test the waters for any strong feelings #speaker:Morgan #mood:happy
 Sounds like the perfect plan, you can ask him when he stops by all his stores in the evening I think he does a few others after this one #speaker:Graciana #mood:happy
 It is quite alright I know which one he frequents around this time 
 and that information is perfectly normal#speaker:Graciana #mood:happy
 Of course #speaker:Morgan #mood:happy
 ...........................#speaker:Graciana #mood:happy
........................... #speaker:Morgan #mood:happy
->Chaotic
**[Go explore somewhere new together]

 Is there even such a place? I have viewed this universe for eons and have seen almost every planet, star, and living being upon them #speaker:Morgan #mood:happy
 Well yes, but with O'Ryan he could take you to new universes right? Ones you would never dream of seeing? If that is your dream.... Do you dream? #speaker:Graciana #mood:happy
 You have a fascinating way of spilling out all your thoughts from your mouth without ever thinking about them don't you #speaker:Morgan #mood:happy
 Yes mamm #speaker:Graciana #mood:happy
 Well most of those ideas do happen to be useful so I can't complain all that much #speaker:Morgan #mood:happy
 Why thank you ma'am#speaker:Graciana #mood:happy
 I will flick your nose and turn you into a cat the next time you call me ma'am #speaker:Morgan #mood:happy
 Yes ma- Righty oh Morgan #speaker:Graciana #mood:happy
 There, much better #speaker:Morgan #mood:happy
 Now I am a little uneasy about going to a different universe or plane of existence that even my knowledge has not seen yet, but I guess it can be done for the sake of our date #speaker:Morgan #mood:happy
 That's the spirit! And plus if it is to weird you can always just go to a favorite place if you have found one since you left the void #speaker:Graciana #mood:happy
 Not really#speaker:Morgan #mood:happy
 Welp go with the flow and make good choices #speaker:Graciana #mood:happy
 That I shall #speaker:Morgan #mood:happy
    ->Chaotic

==Chaotic==
//add more here, transition or like a day goes by or seomthing idk

Well the only logical thing would be to gaze out into the stars and scout out world for our honeymoon and then conquer those worlds#speaker:Morgan #mood:happy 

honeymoon? #speaker:Graciana #mood:happy

Well yes I assume like any Eldritch being with a modicum of respect for themselves that he would propose to me after a successful first date #speaker:Morgan #mood:happy

that quick!??!?! #speaker:Graciana #mood:happy

Well we are very simple beings at our core, we will know whether we will work as partners from the day we attempt to romance one another #speaker:Morgan #mood:happy

If it is meant to be why waste time in reaching our goal of an eternity of harmonic existence #speaker:Morgan #mood:happy

wow that sounds almost pleasant #speaker:Graciana #mood:happy

well until both of us merge together to form a new Eldritch entity that is capable of both its parents and takes control of our current minds with all of the memories of us combined #speaker:Morgan #mood:happy

oh my #speaker:Graciana #mood:happy

yes it is a beautiful process #speaker:Morgan #mood:happy

well if that's what you want #speaker:Graciana #mood:happy

Indeed it is #speaker:Morgan #mood:happy

I wish you the best of luck #speaker:Graciana #mood:happy

Thank you dear, I will try to visit as often as I can #speaker:Morgan #mood:happy

That or send nightmares to you so we can speak when you are off work#speaker:Morgan #mood:happy 

That's not necessary but if you want to I physically can't stop you #speaker:Morgan #mood:happy

Wonderful! #speaker:Graciana #mood:happy

Tata my dear I must go now #speaker:Morgan #mood:happy

Go get em Morgan! #speaker:Graciana #mood:happy

(Days go by without me seeing or hearing from the Morgan, a slight worry started to build as I was unsure of what the outcome of her date was) #speaker:Graciana #mood:happy

(That is until 6 days 6 hours and 6 minutes after the date send off I saw behind the counter The Morgan herself in all of her glory wearing a pink apron and holding O'Ryans hand)

(I guess there is some good endings after all..... even if this one is still kinda weird) #speaker:Graciana #mood:happy

~GoToAppartment()

->END