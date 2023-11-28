INCLUDE globals.ink

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
~convo_numberCC+=1
~convo_numberOR+=1
->NextDayVarAdjust