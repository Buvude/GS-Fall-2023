using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension
{
    using MicroGame.BA;
    using MicroGame;
    using Manager;
    using JetBrains.Annotations;

    public class InkExternalFunctions
    {
        public int day, csConvo;
        public GameObject BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2, BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3;
        private GameObject bun2;

        public InkExternalFunctions(GameObject bBun2, GameObject pickles2, GameObject greens2, GameObject patty2, GameObject condiment2, GameObject veggie2, GameObject bun2, GameObject bBun3, GameObject pickles3, GameObject greens3, GameObject patty3, GameObject condiment3, GameObject veggie3, GameObject bun3)
        {
            BBun2 = bBun2;
            Pickles2 = pickles2;
            Greens2 = greens2;
            Patty2 = patty2;
            Condiment2 = condiment2;
            Veggie2 = veggie2;
            TBun2 = bun2;
            BBun3 = bBun3;
            Pickles3 = pickles3;
            Greens3 = greens3;
            Patty3 = patty3;
            Condiment3 = condiment3;
            Veggie3 = veggie3;
            TBun3 = bun3;
        }

        public void Bind(Story currentStory, BAManeger bAM, Microgamecontroller mGC, dialogueManager dM)
        {
            currentStory.BindExternalFunction("StartBAMicro1", () =>
            {
                mGC.StartBAM(1);
                /*bAM.StartMicroGame(mGC.orderedIngredients);*/
                
            });
            currentStory.BindExternalFunction("StartBAMicro2",() =>
            {
                mGC.StartBAM(BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2);
            });
            currentStory.BindExternalFunction("StartBAMicro3", () =>
            {
                mGC.StartBAM(BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2, BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3);
            });
            currentStory.BindExternalFunction("GoToDiner", (/*int day, int csConvo*/) =>
            {
                day = int.Parse(currentStory.variablesState["dayVar"].ToString());
                /* if (currentStory.variablesState["dayVar"].ToString() == "1")
                 {
                     Debug.Log("made it to day one");
                     dM.ExitDialogueMode(true,day,"GotToDiner func in IEF");
                 }*/
                dM.ExitDialogueMode(true, day, "GotToDiner func in IEF",true);
               
            });
            currentStory.BindExternalFunction("StartO_Ryan", () =>
            {
                dM.charSpeakTo = dialogueManager.speakingTo.O_Ryan;
                dM.oR.gameObject.SetActive(true);
                dM.G.gameObject.SetActive(false);
                dM.cS.gameObject.SetActive(false);
                dM.cC.gameObject.SetActive(false);
                //dM.EnterDialogueMode(dM.TTMicroArcadeConvo);
            });
            currentStory.BindExternalFunction("StartTTMicro", () =>
            {
                mGC.loadTTM();
            });
            currentStory.BindExternalFunction("SaveGame", () =>
            {
                mGC.dM.dV = new DialogueVariables(currentStory);
                mGC.dM.SaveGame();
            });
            currentStory.BindExternalFunction("QuickSave", () =>
            {
                dM.QuickSave();
            });
        }

        public void unBind(Story currentStory)
        {
            currentStory.UnbindExternalFunction("StartBAMicro1");
            currentStory.UnbindExternalFunction("StartBAMicro2");
            currentStory.UnbindExternalFunction("StartBAMicro3");
            currentStory.UnbindExternalFunction("GoToDiner");
            currentStory.UnbindExternalFunction("StartO_Ryan");
            currentStory.UnbindExternalFunction("StartTTMicro");
            currentStory.UnbindExternalFunction("SaveGame");
            currentStory.UnbindExternalFunction("QuickSave");
        }
    }
}
