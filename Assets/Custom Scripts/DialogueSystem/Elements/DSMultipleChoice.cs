using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace DS.Elements
{
    using Enumeration;
    using Elements;
    using DS.Utility;

    public class DSMultipleChoice : DSNode
    {
        public override void Draw()
        {
            //Main Container
            base.Draw();
            Button addChoiceBtn = DSElementUtility.CreateButton("Add Choice", ()=>
            {
                Port choicePort= CreateChoicePort("New Choice");

                Choices.Add("New Choice");

                outputContainer.Add(choicePort);  
            });

            addChoiceBtn.AddToClassList("ds-node__button");

            mainContainer.Insert(1, addChoiceBtn);


            //Output Container
            foreach (string choice in Choices)
            {
                Port choicePort = CreateChoicePort(choice);

                outputContainer.Add(choicePort);


            }

            RefreshExpandedState();
        }
        #region Element Creation
        private Port CreateChoicePort(string choice)
        {
            Port choicePort = this.CreatePort();

            choicePort.portName = "";

            Button deleteChoiceBtn = DSElementUtility.CreateButton("X");
            deleteChoiceBtn.AddToClassList("ds-node__button");

            TextField choiceTextField = DSElementUtility.CreateTextField(choice);

            choiceTextField.AddClasses(
                "ds-node__text-field",
                "ds-node__choice-text-field",
                "ds-node__text-field__hidden");


            choicePort.Add(choiceTextField);
            choicePort.Add(deleteChoiceBtn);

            return choicePort;
        }
        #endregion
        public override void Initialize(Vector2 position)
        {
            base.Initialize(position);

            dT = DSDialogueType.MultipleChoice;

            Choices.Add("New Choice");

        }
    }

}
