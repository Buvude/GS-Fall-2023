INCLUDE globals.ink
EXTERNAL GoToAppartment()
continue to trigger endings
{
-chaosCC>=3:
    triggering chaos ending
    ~chaosOR+=1
-affectionCC>=0:
    triggering good ending
    ~affectionOR+=1
-affectionCC<=0:
    triggering bad ending
    ~affectionOR-=1
}
~convo_numberG+=1
~convo_numberOR+=1
~GoToAppartment()
->DONE