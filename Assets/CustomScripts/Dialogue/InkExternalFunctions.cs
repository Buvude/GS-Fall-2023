using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension
{
    public class InkExternalFunctions
    {
        public void Bind(Story currentStory)
        {
            currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                Debug.Log("called StartBAMicro");
            });
        }
    }
}
