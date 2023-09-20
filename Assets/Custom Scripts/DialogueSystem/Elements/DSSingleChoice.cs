using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace DS.Elements
{
    using Windows;
    using Enumeration;
    using Utility;
    public class DSSingleChoice : DSNode
    {
        public override void Initialize(DSGraphView dSGraphView, Vector2 position)
        {
            base.Initialize(dSGraphView, position);

            dT = DSDialogueType.SingleChoice;

            Choices.Add("Next Dialogue");
        }
        public override void Draw()
        {
            base.Draw();
            //Output Container
            foreach (string choice in Choices)
            {
                Port choicePort =this.CreatePort(choice);

                choicePort.portName = choice;

                outputContainer.Add(choicePort);


            }

            RefreshExpandedState();
        }

      
    }
}
