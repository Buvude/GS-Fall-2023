
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Utility
{
    using Elements;
    public static class DSElementUtility 
    {

  

        public static Button CreateButton(string name, Action onClick = null)
        {
            Button button = new Button(onClick)
            {
                text = name
            };
            return button;
        } 
        public static Foldout CreateFoldout(string title, bool collapsed=false)
        {
            Foldout foldout = new Foldout()
            {
                text = title,
                value = !collapsed
            };
            return foldout;
        }

        public static Port CreatePort(this DSNode node, string portName="", Orientation orientation=Orientation.Horizontal, Direction direction=Direction.Output,Port.Capacity capacity = Port.Capacity.Single)
        {
            Port port = node.InstantiatePort(orientation,direction, capacity, typeof(bool));

            port.portName = portName;

            return port;
        }

        public static TextField CreateTextField(string value=null, EventCallback<ChangeEvent<string>> onValueChanged = null)
        {
            TextField textField = new TextField()
            {
                value = value
            };

            if(onValueChanged != null)
            {
                textField.RegisterCallback(onValueChanged);
            }
            return textField;
        } 
        
        public static TextField CreateTextArea(string value = null, EventCallback<ChangeEvent<string>> onValueChanged = null)
        {
            TextField Textarea=CreateTextField(value, onValueChanged);

            Textarea.multiline = true;

            return Textarea;
        }
    }
}

