using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace DS.Elements
{
    public class DSMultipleChoice : DSNode
    {
        public override void Draw()
        {
            //Main Container
            base.Draw();
            Button addChoiceBtn = new Button()
            {
                text = "Add Choice"
            };

            addChoiceBtn.AddToClassList("ds-node__button");

            mainContainer.Insert(1, addChoiceBtn);


            //Output Container
            foreach (string choice in Choices)
            {
                Port choicePort = InstantiatePort(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(bool));

                choicePort.portName = "";

                Button deleteChoiceBtn = new Button()
                {
                    text = "X"
                };
                deleteChoiceBtn.AddToClassList("ds-node__button");

                TextField choiceText = new TextField()
                {
                    value = choice
                };
                choiceText.AddToClassList("ds-node__text-field");
                choiceText.AddToClassList("ds-node__choice-text-field");
                choiceText.AddToClassList("ds-node__text-field__hidden");
                

                choicePort.Add(choiceText);
                choicePort.Add(deleteChoiceBtn);

                outputContainer.Add(choicePort);


            }

            RefreshExpandedState();
        }

        public override void Initialize(Vector2 position)
        {
            base.Initialize(position);

            dT = DSDialogueType.MultipleChoice;

            Choices.Add("New Choice");

        }
    }

}
