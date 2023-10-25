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
        public GameObject BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2;
        
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
            currentStory.BindExternalFunction("GoToDiner", (/*int day, int csConvo*/) =>
            {
                List<string> temp = currentStory.globalTags;
                foreach (string tag in temp)
                {
                    string[] splitTag = tag.Split(':');
                    if (splitTag.Length != 2)
                    {
                        Debug.LogError("Tag could not be appropriatly parsed: " + tag);
                    }
                    string tagKey = splitTag[0].Trim();
                    string tagValue = splitTag[1].Trim();
                    if(tagKey == "day")
                    {
                        day = int.Parse(tagValue);
                    }
                    else if(tagKey == "CSConvo")
                    {
                        csConvo = int.Parse(tagValue);
                    }
                }
                dM.ExitDialogueMode(true,day,csConvo);
                //dM.EnterDinerMode();
            });
            currentStory.BindExternalFunction("StartO_Ryan", () =>
            {
                dM.charSpeakTo = dialogueManager.speakingTo.O_Ryan;
                dM.EnterDialogueMode(dM.O_RyanIntro);
            });
        }

        public void unBind(Story currentStory)
        {
            currentStory.UnbindExternalFunction("StartBAMicro1");
            currentStory.UnbindExternalFunction("StartBAMicro2");
            currentStory.UnbindExternalFunction("GoToDiner");
            currentStory.UnbindExternalFunction("StartO_Ryan");
        }
    }
}
