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
        }

        public void unBind(Story currentStory)
        {
            currentStory.UnbindExternalFunction("StartBAMicro");
        }
    }
}
