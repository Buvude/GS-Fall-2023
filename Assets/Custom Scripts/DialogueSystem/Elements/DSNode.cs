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
        }
        public virtual void Draw()
        {

            TextField dialogueNameTextField = new TextField()
            {
                value = DialogueName
            };
            titleContainer.Insert(0, dialogueNameTextField);

            //Input Container

            Port inputPort = InstantiatePort(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(bool));

            inputPort.portName = "Dialogue Connection";

            inputContainer.Add(inputPort);

            //Extensions Container

            VisualElement customDataContainer = new VisualElement();

            Foldout textFoldout = new Foldout()
            {
                text = "Dialogue Text"
            };

            TextField textTextField = new TextField()
            {
                value = Text
            };

            textFoldout.Add(textTextField);

            customDataContainer.Add(textFoldout);

            extensionContainer.Add(textFoldout);
        }
    }

}
