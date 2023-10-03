using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension
{
    using MicroGame.BA;
    using MicroGame;
    public class InkExternalFunctions
    {

        
        public void Bind(Story currentStory, BAManeger bAM, Microgamecontroller mGC)
        {
            currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                mGC.StartBAM();
                /*bAM.StartMicroGame(mGC.orderedIngredients);*/
                
            });
        }

        public void unBind(Story currentStory)
        {
            currentStory.UnbindExternalFunction("StartBAMicro");
        }
    }
}
