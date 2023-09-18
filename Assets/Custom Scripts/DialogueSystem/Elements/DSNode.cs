using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Elements
{
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

            TextField dialogueNameTextField = new TextField()
            {
                value = DialogueName
            };

            dialogueNameTextField.AddToClassList("ds-node__text-field");
            dialogueNameTextField.AddToClassList("ds-node__filename-text-field");
            dialogueNameTextField.AddToClassList("ds-node__text-field__hidden");

            titleContainer.Insert(0, dialogueNameTextField);

            //Input Container

            Port inputPort = InstantiatePort(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(bool));

            inputPort.portName = "Dialogue Connection";

            inputContainer.Add(inputPort);

            //Extensions Container

            VisualElement customDataContainer = new VisualElement();

            customDataContainer.AddToClassList("ds-custom-data-container");

            Foldout textFoldout = new Foldout()
            {
                text = "Dialogue Text"
            };

            TextField textTextField = new TextField()
            {
                value = Text
            };

            textTextField.AddToClassList("ds-node__text-field");
            textTextField.AddToClassList("ds-node__quote-text-field");
            textFoldout.Add(textTextField);

            customDataContainer.Add(textFoldout);

            extensionContainer.Add(textFoldout);
        }
    }

}
