using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension
{
    using MicroGame.BA;
    using MicroGame;
    using Manager;

    public class InkExternalFunctions
    {

        
        public void Bind(Story currentStory, BAManeger bAM, Microgamecontroller mGC, dialogueManager dM)
        {
            currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                mGC.StartBAM();
                /*bAM.StartMicroGame(mGC.orderedIngredients);*/
                
            });
            currentStory.BindExternalFunction("GoToDiner", () =>
            {
                dM.ExitDialogueMode(true);
                //dM.EnterDinerMode();
            });
            currentStory.BindExternalFunction("StartO_Ryan", () =>
            {
                dM.charSpeakTo = dialogueManager.speakingTo.O_Ryan;
                dM.EnterDialogueMode(dM.inkJSON2);
            });
        }

        public void unBind(Story currentStory)
        {
            currentStory.UnbindExternalFunction("StartBAMicro");
        }
    }
}
