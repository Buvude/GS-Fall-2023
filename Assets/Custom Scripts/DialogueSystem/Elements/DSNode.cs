using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Elements
{
    using Enumeration;
    using Utility;
    public class DSNode : Node
    {
        //this is used as a base class that all nodes will inherit from
        public string DialogueName { get; set; }
        public List<string> Choices { get; set; }
        public string Text { get; set; }
        public DSDialogueType dT { get; set; }

        public virtual void Initialize(Vector2 position)
        {
            DialogueName = "DialogueName";
            Choices = new List<string>();
            Text = "Dialogue text.";

            SetPosition(new Rect(position, Vector2.zero));

            mainContainer.AddToClassList("ds-node__main-container");
            extensionContainer.AddToClassList("ds-node__extension-container");
        }
        public virtual void Draw()
        {
            
            TextField dialogueNameTextField = DSElementUtility.CreateTextField(DialogueName);

            dialogueNameTextField.AddClasses(
                "ds-node__text-field",
                "ds-node__filename-text-field",
                "ds-node__text-field__hidden"
                );

            titleContainer.Insert(0, dialogueNameTextField);

            //Input Container

            Port inputPort = this.CreatePort("Dialogue Connection", Orientation.Horizontal, Direction.Input, Port.Capacity.Multi);

            inputPort.portName = "Dialogue Connection";

            inputContainer.Add(inputPort);

            //Extensions Container

            VisualElement customDataContainer = new VisualElement();

            customDataContainer.AddToClassList("ds-custom-data-container");

            Foldout textFoldout = DSElementUtility.CreateFoldout("Dialogue Text");

            TextField textTextField = DSElementUtility.CreateTextArea(Text);

            textTextField.AddClasses(
                "ds-node__text-field",
                "ds-node__quote-text-field"
                );
            textFoldout.Add(textTextField);

            customDataContainer.Add(textFoldout);

            extensionContainer.Add(textFoldout);
        }
    }

}
