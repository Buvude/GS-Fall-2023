INCLUDE globals.ink

continue to trigger endings
{
-chaosM>=3:
    triggering chaos ending
    ~chaosOR+=1
-affectionM>=0:
    triggering good ending
    ~affectionOR+=1
-affectionM<=0:
    triggering bad ending
    ~affectionOR-=1
}
~convo_numberM+=1
~convo_numberOR+=1
->NextDayVarAdjust