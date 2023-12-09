INCLUDE globals.ink

Ah, there you are, human! Come, serve me! #speaker:Himber #mood:neutral

*[Fine...]
    Hey, how can I help you two? #speaker:Graciana #mood:neutral
    
    //"Hey there, Gnomies! #speaker:Graciana #mood:neutral"
    //She shouldn't name-drop them as "Gnomies" until the second or third branch lmao
    -> GnomiesConvoStart1
*[Serve yourself.]
Sorry, in a minute! #speaker:Graciana #mood:neutral
(Yeah, right.) #speaker:Graciana #mood:happy
    -> DONE

==GnomiesConvoStart1==
Ah, finally, it's about time! #speaker:Himber #mood:neutral
What took you so long?

... #speaker:Graciana #mood:angry

Regardless, I think you already know what I want, don't you human? #speaker:Himber #mood:happy

...Do I? #speaker:Graciana #mood:think

You should! I require the same food item as last time! #speaker:Himber #mood:angry
Surely you haven't forgotten already?

Uh... #speaker:Graciana #mood:think

* [Tears of the innocent]
    ->chaos1
* [Lingonberry Sweet Pie]
    ->good1
* [A chunk of rock]
    ->bad1
    
==good1==
~affectionG=affectionG+2
What do you take me for? Of course I remember it was Lingonberry Sweet Pie! #speaker:Graciana #mood:happy #sfx:GainedPoint

Ah, very good! I see you are smarter than the average human! #speaker:Himber #mood:happy

(Is that why I'm working at a Diner...?) #speaker:Graciana #mood:think
Well, thanks I guess. #speaker:Graciana #mood:happy
Anything for Hograt today? #speaker:Graciana #mood:think
(I look down at Hograt, and he shakes his head.)

No, Hograt is still full from last time. #speaker:Himber #mood:neutral
I shall ignore your acknowledgement of him since you remembered my order, but I remind you once more to not distract him.

Right... Guess I forgot about that... #speaker:Graciana #mood:neutral
Well, one slice of Lingonberry Sweet Pie, coming right up! #speaker:Graciana #mood:happy
//kitchen scene change
(I head back into the kitchen, grabbing a slice of pie and warming it up in the microwave.) #speaker:Graciana #mood:neutral
(Hm... last time, I put some Cthulu Dandruff on as seasoning...) #speaker:Graciana #mood:think
(But... He was actually not terrible to me this time, so maybe I just give it to him normally.)
(Taking the slice out, I go back out to the Dining Room and place the pie on the table.) #speaker:Graciana #mood:neutral
//diner scene change
One slice of Lingonberry Sweet Pie! #speaker:Graciana #mood:happy

Yes, right on time too! You are doing wonderful today, human! #speaker:Himber #mood:happy
    -> yummypie
==bad1==
~affectionG=affectionG-1
What, like, a chunk of rock or something? #speaker:Graciana #mood:think #sfx:LostPoint
I gave you a piece of the old Granite table, right?

What? No! That is what you gave to Hograt, not me! #speaker:Himber #mood:angry
How could you possibly get us confused? We are starkly different!

Right, right... My bad... #speaker:Graciana #mood:neutral

I ordered a fine slice of warm, fresh, Lingonberry Sweet Pie! #speaker:Himber #mood:angry

Right, I'm on it! #speaker:Graciana #mood:angry
//kitchen scene change
(I head to the back kitchen and grab a slice of pie, warming it up in the microwave.) #speaker:Graciana #mood:angry
(...This guy is driving me crazy...)
(Not to mention that poor subgnome...)
(I take the slice out of the microwave, and bring it out to the Dining Room.) #speaker:Graciana #mood:neutral
//diner scene change
One Lingonberry Sweet Pie, served hot. #speaker:Graciana #mood:neutral

Perfect. I must say, you are much faster than you were last time! #speaker:Himber #mood:happy

(Oh, yeah...) #speaker:Graciana #mood:neutral
(Last time, I put in some Cthulu Dandruff as seasoning, because he's a jerk...) #speaker:Graciana #mood:think
(I was too busy being pissed off to do it this time, I guess. Oh well.) #speaker:Graciana #mood:neutral
    -> yummypie
==chaos1==
~chaosG=chaosG+2
//chaos
Probably like, tears of the innocent... #speaker:Graciana #mood:angry #sfx:CosmicPoint

What was that? You should not mumble! #speaker:Himber #mood:neutral

Oh, n-nothing! #speaker:Graciana #mood:neutral

Hm... #speaker:Himber #mood:neutral
While yes, that does sound delicious, that is not what I ordered last time.
I ordered a Lingonberry Sweet Pie! #speaker:Himber #mood:angry

Oh, right, my mistake... #speaker:Graciana #mood:neutral
(Wait, did he say--) #speaker:Graciana #mood:think

<i>Ahem.</i> #speaker:Himber #mood:neutral

Right, yeah, I'll go get that for ya. #speaker:Graciana #mood:neutral
//kitchen scene change
(I head to the back kitchen and grab a slice of pie, warming it up in the microwave.)
(...Was he saying that he... Wants to eat tears?) #speaker:Graciana #mood:think
(This dude makes no sense to me...)
(I take the slice out of the microwave, and bring it out to the Dining Room.) #speaker:Graciana #mood:neutral
//diner scene change
One Lingonberry Sweet Pie, served hot. #speaker:Graciana #mood:neutral

Perfect. I must say, you are much faster than you were last time! #speaker:Himber #mood:happy

(Oh, right...) #speaker:Graciana #mood:neutral
(Last time, I put in some Cthulu Dandruff as seasoning, because he was being a jerk...) #speaker:Graciana #mood:think
(Oh well, guess he gets to eat a normal slice today.) #speaker:Graciana #mood:neutral
    -> yummypie
==yummypie==
(He stabs through the pie with his fork, and puts the whole piece in his mouth!) #speaker:Graciana #mood:neutral

... #speaker:Himber #mood:neutral
Something is... Off... #speaker:Himber #mood:sad

(Wuh oh... Did he notice I've been microwaving them?) #speaker:Graciana #mood:think

This slice isn't as... Flavorful, as the one I had the previous encounter. #speaker:Himber #mood:sad
That slice was bursting with flavors beyond my comprehension, while this slice is simply...
Pedestrian. #speaker:Himber #mood:neutral

Pedestrian? #speaker:Graciana #mood:think
(I guess putting in an Eldritch seasoning would technically make it flavorful beyond comprehension, but...)
(Tasty? I remember he ate it without issue, but the fact that he thinks it's bad without it...)

What are you doing staring off into the Void? I am a customer airing a grievance here! #speaker:Himber #mood:neutral

* [Lie]
    -> chaos2
* [Brush it off]
    -> bad2
* [Tell the truth]
    -> good2

==good2==
~affectionG=affectionG+2

Well, honestly... #speaker:Graciana #mood:sad #sfx:GainedPoint
I might've...
Put some Cthulu Dandruff seasoning on the pie the first time...

... #speaker:Himber #mood:neutral
Hoohoo! That explains it! #speaker:Himber #mood:happy 
How did you know that was my favorite?! 

...Your favorite? #speaker:Graciana #mood:think

Yes, we topgnomes love to feast on Eldritch cuisine! #speaker:Himber #mood:happy
It reminds us of our childhood on the surface, back in Tometopia!

Eldritch cuisine?! #speaker:Graciana #mood:fear
(And... The surface?) #speaker:Graciana #mood:think

Yes! You know, beast parts, seasonings, hides, stews, marrow... #speaker:Himber #mood:neutral
Although, I wouldn't trust an establishment like <i>this</i> to properly cook Fried Aboleth for its life, so a Lingonberry Sweet Pie is the next best thing.

Right... #speaker:Graciana #mood:neutral
(Do we even have Aboleth? I'm surprised we even had Cthulu Dandruff...) #speaker:Graciana #mood:think
So... #speaker:Graciana #mood:neutral
What about Hograt, a subgnome? #speaker:Graciana #mood:think

Well, if you recall from our last encounter, subgnomes dine on the finest of ores and natural rock. #speaker:Himber #mood:neutral
As is natural, being a species born and raised below the surface.
    -> surfaces
==bad2==
~affectionG=affectionG-1

Oh, uh... #speaker:Graciana #mood:neutral #sfx:LostPoint
Were you saying something? #speaker:Graciana #mood:think

Excuse me? #speaker:Himber #mood:neutral

Uh, I mean... #speaker:Graciana
...
What about Hograt? Does he want anything?

No, as I mentioned previously, he is still full from his prior meal! Please, listen when I am speaking to you! #speaker:Himber #mood:angry
Subgnomes from below the surface do not need to eat as much as us topgnomes! #speaker:Himber #mood:neutral
    ->surfaces
==chaos2==
~chaosG=chaosG+2

Uh... #speaker:Graciana #mood:sad #sfx:CosmicPoint
That's because I... Uh...
We... Ran out of the special spices that we use... For extra flavor... #speaker:Graciana #mood:neutral
(I really can't lie to save my life, huh...)

Ran out? #speaker:Himber #mood:angry

Uh, yeah... #speaker:Graciana #mood:think
We get it from the depths of... A mine... In space....

Hmph! #speaker:Himber #mood:angry
I bet even Hograt could sniff out this spice in a matter of minutes! Subgnomes are known for navigating mines!

...They are? #speaker:Graciana #mood:think

Yes, of course! They are acustomed to exist below the surface, why wouldn't he be? #speaker:Himber #mood:neutral
    ->surfaces
==surfaces==
... #speaker:Graciana #mood:neutral
What do you mean by "below the surface" exactly? #speaker:Graciana #mood:think

What do you mean, what do I mean? I mean that exactly! #speaker:Himber #mood:neutral

So Hograt is from... Underground? #speaker:Graciana #mood:neutral

Yes, precisely. Like all subgnomes, he was born from the dirt of Tometopia, and raised beneath the surface. #speaker:Himber #mood:neutral
Truly, a horrifying existence. #speaker:Himber #mood:sad
Some say the reason why subgnomes hardly speak is because of the horrors they witnessed...

And what about you? #speaker:Graciana #mood:think

Well, as a topgnome, I was of course born and raised above the surface of Tometopia. #speaker:Himber #mood:happy
Tometopia is such a beautiful specimen of a world! Full of magic, wonder, rich with materials...
Every being wants a piece of Tometopia! I'm sure even some of the material used to make this Diner are straight from Tometopia!
Most visitors that come to Tometopia seldom depart! They want to live there forever!

... #speaker:Graciana #mood:neutral
Only above the surface though, right? #speaker:Graciana #mood:think

Yes, of course! No one would dare to go beneath the surface! #speaker:Himber #mood:neutral

And... What's down there, exactly? #speaker:Graciana

As I said, full of horrors! #speaker:Himber #mood:angry
Eldritch monsters ravage the cave systems, and feast on the defenseless subgnomes!

Is this true?! #speaker:Graciana #mood:fear
(I look down at Hograt, and notice he's been trembling in fear...) #speaker:Graciana #mood:sad
I guess so...

Hograt, stop moving so much! You are misaligning my chakras! #speaker:Himber #mood:angry
And of course it is! I do not tell lies! I am magically incapable of doing so! #speaker:Himber #mood:neutral

* [Magically?]
    ->magically
* [More about subgnomes?]
    ->moresubgnome

==magically==
~chaosG=chaosG+2

Magically? #speaker:Graciana #mood:think #sfx:CosmicPoint
Like, you're saying you're magical?

Yes...? Why is this confusing...? #speaker:Himber #mood:neutral

Uh... Why wouldn't it be? You're telling me that magic is real?! #speaker:Graciana #mood:think

Ah, yes, I suppose it makes sense that a human would not know about the vast complexities of the arcane arts. #speaker:Himber #mood:neutral

Yes, us topgnomes possess great magical capabilities. That is our birthright when being born above the surface. #speaker:Himber #mood:neutral
Like so! #speaker:Himber #mood:happy

(Himber snaps his fingers, and a bird flies out from under his sleeve, and flies out through the exit portal!) #speaker:Graciana #mood:fear
Oh, wow! That's incredible!

Oh, that is purely amateur arcana. I am capable of much more complexities. #speaker:Himber #mood:neutral

Really? #speaker:Graciana #mood:think
Could you, perhaps maybe... Uh...
Would you able to, say, I dunno...
Fix my eyesight? Give me perfect 20/20 vision? #speaker:Graciana #mood:happy

Ha! That is child's play. Any novice topgnome can mend eyesight! #speaker:Himber #mood:happy

(He snaps his fingers once more, and...) #speaker:Graciana #mood:happy
... #speaker:Graciana #mood:neutral
Nothing's changed... #speaker:Graciana #mood:sad

What? #speaker:Himber #mood:sad
No, surely that must've mended your eyesight! My magic is flawless!
It's your eyes! There must be something interfering with my magic! #speaker:Himber #mood:angry
Do you possess magical capabilities as well?!

Not the last time I checked... #speaker:Graciana
(Damn, I was really hoping that would've worked...)

    ->conclusion
==moresubgnome==
~affectionG=affectionG+2

Wow, that must've been a really bad time then... #speaker:Graciana #mood:sad #sfx:GainedPoint
You mentioned they were defenseless? If they are... Why do they keep being born down there? #speaker:Graciana #mood:think

It is not that simple, silly human. #speaker:Himber #mood:neutral
Subgnomes are born from the rare mineral and ores present beneath the surface. Without those, they do not exist.
And they must consume specific ores if they wish to grow stronger and sustain themselves.
Unfortunately, not many survive long enough... #speaker:Himber #mood:sad
But the few that do possess impressive physical prowess! #speaker:Himber #mood:happy

...Do they? Hograt looks... Not the strongest... He's thinner than paper... #speaker:Graciana #mood:sad

Again, there you go prattling with your human ideologies. #speaker:Himber #mood:neutral
By Tometopia's standards, and the biology of us gnomes as a whole, subgnomes possess great physical power.
Hograt's jaw can bite through solid steel! #speaker:Himber #mood:happy

I guess that makes sense, if he eats rocks and ores. #speaker:Graciana #mood:think
Still, I guess it's just odd, considering your... Dynamic?

What do you mean, dynamic? #speaker:Himber #mood:neutral

Y'know, how you're standing on top his head? And how you called him your "steed" a while back? #speaker:Graciana #mood:angry

Ah, yes, I cannot expect you to grasp Tometopia culture so simply like we do. #speaker:Himber #mood:neutral
    -> conclusion

==conclusion==
Perhaps that is a conversation for another day. I have already spent too much time in this... <i>Establishment...</i> #speaker:Himber #mood:neutral

Right... #speaker:Graciana #mood:angry

We shall be off. Come now Hograt, onward! #speaker:Himber #mood:neutral

(He taps his foot on Hograt's head, and they head off before leaving a stack of gold coins on the counter.) #speaker:Graciana #mood:angry
...
Yeah, I still don't think I'm much of a fan of that guy...
Wonder what the deal with Hograt is, though... #speaker:Graciana #mood:think
...
Anyways, I've got some more work to do. #speaker:Graciana #mood:neutral

~GoToDiner()
    -> DONE