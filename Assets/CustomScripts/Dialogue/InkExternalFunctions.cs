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
            currentStory.BindExternalFunction("StartBAMicro1", () =>
            {
                mGC.StartBAM(1);
                /*bAM.StartMicroGame(mGC.orderedIngredients);*/
                
            });
            currentStory.BindExternalFunction("StartBAMicro2",() =>
            {
                mGC.StartBAM(2);
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
            currentStory.UnbindExternalFunction("StartBAMicro1");
            currentStory.UnbindExternalFunction("StartBAMicro2");
            currentStory.UnbindExternalFunction("GoToDiner");
            currentStory.UnbindExternalFunction("StartO_Ryan");
        }
    }
}
