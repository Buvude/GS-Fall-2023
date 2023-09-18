using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using UnityEngine.UIElements;
using UnityEditor;

namespace DS.Windows
{
    using DS.Elements;
    public class DSGraphView : GraphView
    {
        public DSGraphView()
        {
            AddManipulators();
            AddGridBackground();

            AddStyles();
        }



        private void AddManipulators()
        {
            this.AddManipulator(new ContentDragger());
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);

            this.AddManipulator(CreateNodeContextualMenu("Add Node (Single Choice)", DSDialogueType.SingleChoice));
            this.AddManipulator(CreateNodeContextualMenu("Add Node (Multiple Choice)", DSDialogueType.MultipleChoice));
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());

        }

        private IManipulator CreateNodeContextualMenu(string actionTitle, DSDialogueType dT)
        {
            ContextualMenuManipulator cMM = new ContextualMenuManipulator(
                menuEvent => menuEvent.menu.AppendAction(actionTitle, actionEvent => AddElement(CreateNode(dT, actionEvent.eventInfo.localMousePosition)))
                );

            return cMM;
        }

        private DSNode CreateNode(DSDialogueType dT, Vector2 position)
        {
            Type nodeType = Type.GetType($"DS.Elements.DS{dT}");

            DSNode node = (DSNode)Activator.CreateInstance(nodeType);

            node.Initialize(position);
            node.Draw();
            return node;
        }

        private void AddStyles()
        {
            StyleSheet sS = (StyleSheet)EditorGUIUtility.Load("DialogueSystem/DSGraphViewStyles.uss");

            styleSheets.Add(sS);
        }

        private void AddGridBackground()
        {
            GridBackground gB = new GridBackground();

            gB.StretchToParentSize();

            Insert(0, gB);
        }
    }

}