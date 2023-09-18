using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace DS.Elements
{
    public class DSSingleChoice : DSNode
    {
        public override void Draw()
        {
            base.Draw();
            //Output Container
            foreach (string choice in Choices)
            {
                Port choicePort = InstantiatePort(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(bool));

                choicePort.portName = choice;

                outputContainer.Add(choicePort);


            }

            RefreshExpandedState();
        }

        public override void Initialize(Vector2 position)
        {
            base.Initialize(position);

            dT = DSDialogueType.SingleChoice;

            Choices.Add("Next Dialogue");
        }
    }
}
