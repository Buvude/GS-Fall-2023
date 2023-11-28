INCLUDE globals.ink

continue to trigger endings
{
-chaosN>=3:
    triggering chaos ending
    ~chaosOR+=1
-affectionN>=0:
    triggering good ending
    ~affectionOR+=1
-affectionN<=0:
    triggering bad ending
    ~affectionOR-=1
}
~convo_numberN+=1
~convo_numberOR+=1
->NextDayVarAdjust
