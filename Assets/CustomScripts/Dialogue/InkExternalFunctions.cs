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
    using UnityEngine.SceneManagement;
    using UnityEditor;
    using System.Runtime.CompilerServices;

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
            currentStory.BindExternalFunction("StartBAMPractice",()=>{
                SceneManager.LoadScene(2);
            });
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
                day = PlayerPrefs.GetInt("dayVar");
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
                dM.N.gameObject.SetActive(false);
                dM.G.gameObject.SetActive(false);
                dM.M.gameObject.SetActive(false);
                //dM.EnterDialogueMode(dM.TTMicroArcadeConvo);
                switch (PlayerPrefs.GetString("weekDay"))
                {
                    case "Mon":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["monNight"]);
                        break;
                    case "Tue":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["tueNight"]);
                        break;
                    case "Wed":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["wedNight"]);
                        break;
                    case "Thu":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["thuNight"]);
                        break;
                    case "Fri":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["friNight"]);
                        break;
                    case "Sat":
                        dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["satNight"]);
                        break;
                    default:
                        break;
                }
            });
            currentStory.BindExternalFunction("StartTTMicro", () =>
            {
                dM.QuickSave();
                PlayerPrefs.SetString("currentConvo", currentStory.variablesState["currentConvo"].ToString());
                mGC.loadTTM();
            });
            currentStory.BindExternalFunction("SaveGame", () =>
            {
                dM.dV = new DialogueVariables(currentStory);
                dM.SaveGame();
            });
            currentStory.BindExternalFunction("QuickSave", () =>
            {
                dM.dV = new DialogueVariables(currentStory);
                dM.QuickSave();
            });
            currentStory.BindExternalFunction("QuickLoad", () =>
            {
                dM.dV = new DialogueVariables(currentStory);
                dM.QuickLoad();
            });
            currentStory.BindExternalFunction("NewDay", () =>
            {
                if (PlayerPrefs.GetString("weekDay") == "Sun")
                {
                    SceneManager.LoadScene(5);
                }
                else { SceneManager.LoadScene(1); }
            });
            currentStory.BindExternalFunction("GoToAppartment", () =>
            {
                PlayerPrefs.SetString("timeOfDay", "Night");
                dM.SaveGame();
                SceneManager.LoadScene(5);
            });
            currentStory.BindExternalFunction("EndGame", () =>
            {
                PlayerPrefs.DeleteAll();
                SceneManager.LoadScene(0);
            });
            currentStory.BindExternalFunction("EndGame2", () =>
            {
                PlayerPrefs.DeleteAll();
                Application.Quit();
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
            currentStory.UnbindExternalFunction("QuickLoad");
            currentStory.UnbindExternalFunction("NewDay");
            currentStory.UnbindExternalFunction("GoToAppartment");
            currentStory.UnbindExternalFunction("EndGame");
            currentStory.UnbindExternalFunction("EndGame2");
        }
    }
}
