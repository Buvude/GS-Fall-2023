INCLUDE globals.ink
EXTERNAL GoToAppartment()

->MainCS3

==MainCS3==
Ay, Gracie, ya got a minute? #speaker:Chef Swatts

* [Yeah]
    Yeah, I got some time. #speaker:Graciana #mood:neutral

    Ay, good good! c'mere for a sec, ya? #speaker:Chef Swatts #mood:neutral

    What's happenin'? #speaker:Graciana #mood:think

    Ay, just wanted to lend ya ear for a minute #speaker:Chef Swatts
    //go to ending
    {
    -chaosCS>=9:
        ->ChaosEndCS
    -affectionCS>=0:
        ->GoodEndCS
    -affectionCS<0:
        ->BadEndCS
    }
    ->DONE //temporary place holder so no error
    
* I'm busy
    -> DONE
    
    
    
    
==GoodEndCS==
I been thinkin' about what ya been sayin'. #speaker:Chef Swatts
I think I'ma start headin' back to Dipterra more often.

O-oh! #speaker:Graciana
What made you decide that?

Well, I thought 'bout it... #speaker:Chef Swatts
Who knows how many folk are like me, ya? Insectica that've suffered 'cuz of the way tha world is.
I wanna help tha folk of Dipterra. I feel like... Like I gotta. Like it's my... Destiny?

Destiny... #speaker:Graciana #mood:think

Ya. I got my own Personal Portal Device, an' I can bring tha leftover scraps from here, an' go scoutin' around, handing 'em out to whoever seems like they strugglin'.
I been avoiding goin' back for years an' years. I think it's time I finally pay a proper visit to where I'm from, ya?
Besides...
I feel... Guilty. Havin' this Portal Device. This life. This job. All this food...
When ya have tha power to make a change in ya world, but ya choose not too... It makes me no better than tha spiders, ya?

I see what you mean... #speaker:Graciana #mood:think
Yeah. I think that's a great idea. #speaker:Graciana #mood:happy
I think you can make a pretty great difference, even if you just start out small. 

I think so too, ya. #speaker:Chef Swatts
Ya gonna come wit' me and help?

T-to Dipterra?! #speaker:Graciana #mood:fear
Uh... I dunno if I'm built for a place like that...
But I wouldn't mind helping you prepare some food to bring over, for sure!

Ay, that sounds good to me. #speaker:Chef Swatts #mood:neutral
Once things calm down a bit, an' O'Ryan finally finds a proper manager so I don' have to stay here all the time...
I'm headin' back to Dipterra, babeh! #speaker:Chef Swatts #mood:happy
~convo_numberOR+=1
~convo_numberCS+=1
~affectionOR+=1
~GoToAppartment()
->DONE


==BadEndCS==
I ain't got no reason to evah go back to Dipterra. #speaker:Chef Swatts

R-really? What makes you say that...? #speaker:Graciana #mood:sad

Well, I told ya what it's like. It's a real mess. #speaker:Chef Swatts #mood:sad
Ain't nothin' left for me there.
Here, I gotta job, I can sleep safely in tha back room, wit' all tha food I can eat...
Ain't no reason for me to ever go back to Dipterra, ya? #speaker:Chef Swatts #mood:neutral

I mean... Sure, yeah, I can see that, b-but, what about-- #speaker:Graciana #mood:sad

And ya too, Gracie. Ya stuck on ya Earth, but to me it looks like just another Dipterra, ya know? #speaker:Chef Swatts

Well I mean-- #speaker:Graciana

So I want ya to have this. Cuz I ain't goin' nowhere else but here! #speaker:Chef Swatts #mood:happy

(He takes my hand and places his Personal Portal Device in it, without any hesitation.) #speaker:Graciana
...Are you sure about this...?

Ya, of course! Ya said that portal travel is inconvenient on Earth, ya? #speaker:Chef Swatts
Ya can use that to get around, no sweat!
I got no problem stayin' here!
For the rest of my life... #speaker:Chef Swatts #mood:sad
Ahahaha! #speaker:Chef Swatts #mood:happy

(I mean, he seems content with staying here... But is that really what he wants? To stay in this dinky kitchen for the rest of his life?) #speaker:Graciana #mood:think
(He could be doing so much more, I think...)
~convo_numberOR+=1
~convo_numberCS+=1
~affectionOR-=1
~GoToAppartment()
->DONE

==ChaosEndCS==
I got an idea for what I wanna do afta O'Ryan finally finds a proper manager #speaker:Chef Swatts

What do you mean? #speaker:Graciana #mood:think

Well, I've been here for a loooong time at this point. Almost too long. #speaker:Chef Swatts #mood:sad
So, I was thinkin' I gotta finally do somethin' impactful wit' my life. Make a real change, ya? #speaker:Chef Swatts #mood:neutral

Oh! That sounds like a great idea! #speaker:Graciana #mood:happy
What did you have in mind? #speaker:Graciana #mood:think

Well, ya see, I got this Personal Portal Device I snagged. And I got some experience dealin' with spiders, ya? #speaker:Chef Swatts #mood:neutral
So, I figured I'ma go back to my home of Dipterra, and help out the otha insectica...
By startin' a revolution! #speaker:Chef Swatts #mood:happy

A revolution?! #speaker:Graciana #mood:fear

Ya! I figure I can go back to Dipterra, rally up all tha flyfolk, an' get ready to fight 'em all! #speaker:Chef Swatts
Wit' hundreds of us, we outnumber tha spiders. It's just a matter of stayin' organized, ya? #speaker:Chef Swatts #mood:neutral
We all suffer in fear under tha spiders for too long! #speaker:Chef Swatts #mood:angry

R-right! Exactly! #speaker:Graciana #mood:neutral
I feel like... The insectica of Dipterra would be behind you, 100%. #speaker:Graciana #mood:happy
You have my full support, no matter what.

Ay, ya gonna come fight tha spiders wit' me? #speaker:Chef Swatts #mood:neutral

W-well, uh, aha... I don't know if I-- #speaker:Graciana #mood:fear

Ahaha! Jus' kiddin' ya! #speaker:Chef Swatts #mood:happy
They would eat ya alive in a minute. #speaker:Chef Swatts #mood:neutral

Y-yeah... I figured... #speaker:Graciana #mood:sad
(I'm glad that Chef Swatts has found some sort of "greater purpose" aside from working here for the rest of his life.) #speaker:Graciana #mood:happy
(I wonder when I'll get a chance to lead such a great difference like that...) #speaker:Graciana #mood:think
~convo_numberOR+=1
~convo_numberCS+=1
~chaosOR+=1
~GoToAppartment()
->DONE