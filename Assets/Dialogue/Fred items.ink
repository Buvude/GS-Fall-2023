
INCLUDE globals.ink
{
    -chaosF>=chaosTotalF:
        ->Flicense
    -affectionF>=0:
        ->Fletter
    -affectionF<0:
        ->Fhelmet
    }
==Fletter==
//good
Fred gave me this after he started attending school... #speaker:Graciana #mood:neutral #pu:fletter
That little star is student of the month! #speaker:Graciana #mood:happy #pd: 
->DONE
==Fhelmet==
//bad
Fred... #speaker:Graciana #mood:sad #pu:fhelmet
I'm so sorry... #pd: 
->DONE
==Flicense==
//chaos
Fred gave me this after he quit UMS... #speaker:Graciana #mood:neutral #pu:fid
To come live with me! #speaker:Graciana #mood:happy
He's playing outside right now, I should probably call him in soon... #speaker:Graciana #mood:think #pd: 
->DONE