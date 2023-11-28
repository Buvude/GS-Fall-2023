INCLUDE globals.ink

continue to trigger endings
{
-chaosF>=3:
    triggering chaos ending
    ~chaosOR+=1
-affectionF>=0:
    triggering good ending
    ~affectionOR+=1
-affectionF<=0:
    triggering bad ending
    ~affectionOR-=1
}
~convo_numberF+=1
~convo_numberOR+=1
->NextDayVarAdjust