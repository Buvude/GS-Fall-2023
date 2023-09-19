using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using UnityEngine.UIElements;
using UnityEditor;

namespace DS.Windows
{
    using Elements;
    using Enumeration;
    using Utility;
    public class DSGraphView : GraphView
    {
        //private VisualElement contentViewContainer = new VisualElement();

        private DSEditorWindow editorwindow;
        private DSSearchWindow searchWindow;

        public DSGraphView(DSEditorWindow window)
        {
            AddManipulators();
            AddSearchWindow();
            AddGridBackground();

            AddStyles();
            this.editorwindow = window;
        }


        #region Overide Methods

        public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
        {
            List<Port> compatiblePorts = new List<Port>();

            ports.ForEach(port =>
            {
                if (startPort == port)
                {
                    return;
                }

                if (startPort.node == port.node)
                {
                    return;
                }

                if (startPort.direction == port.direction)
                {
                    return;
                }

                compatiblePorts.Add(port);
            });
            return compatiblePorts;
        }
        #endregion

        #region Manipulators
        private void AddManipulators()
        {
            this.AddManipulator(new ContentDragger());
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);

            this.AddManipulator(CreateNodeContextualMenu("Add Node (Single Choice)", DSDialogueType.SingleChoice));
            this.AddManipulator(CreateNodeContextualMenu("Add Node (Multiple Choice)", DSDialogueType.MultipleChoice));
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());

            this.AddManipulator(createGroupContextualMenu());

        }

        private IManipulator createGroupContextualMenu()
        {
            ContextualMenuManipulator cMM = new ContextualMenuManipulator(
                menuEvent => menuEvent.menu.AppendAction("Add group", actionEvent => AddElement(CreateGroup("Dialogue Group", GetLocalMousePosition(actionEvent.eventInfo.localMousePosition))))
                );

            return cMM;
        }



        private IManipulator CreateNodeContextualMenu(string actionTitle, DSDialogueType dT)
        {
            ContextualMenuManipulator cMM = new ContextualMenuManipulator(
                menuEvent => menuEvent.menu.AppendAction(actionTitle, actionEvent => AddElement(CreateNode(dT, GetLocalMousePosition(actionEvent.eventInfo.localMousePosition))))
                );

            return cMM;
        }
        #endregion

        #region Elements Addition

        public void AddSearchWindow()
        {
            if (searchWindow == null)
            {
                searchWindow = ScriptableObject.CreateInstance<DSSearchWindow>();

                searchWindow.initialize(this);
            }

            nodeCreationRequest = context => SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), searchWindow);
        }

        public Group CreateGroup(string Title, Vector2 localMousePosition)
        {
            Group group = new Group()
            {
                title = Title
            };

            group.SetPosition(new Rect(localMousePosition, Vector2.zero));

            return group;


        }
        public DSNode createNodeActivator(DSDialogueType dT, Vector2 position)
        {
            return CreateNode(dT, position);

        }
        private DSNode CreateNode(DSDialogueType dT, Vector2 position)
        {
            Type nodeType = Type.GetType($"DS.Elements.DS{dT}");

            DSNode node = (DSNode)Activator.CreateInstance(nodeType);

            node.Initialize(position);
            node.Draw();
            return node;
        }
        #endregion

        #region Elements Creation
        private void AddStyles()
        {
            this.AddStyleSheets(
                "DialogueSystem/DSGraphViewStyles.uss",
                "DialogueSystem/DSNodeStyles.uss"
                );
        }

        private void AddGridBackground()
        {
            GridBackground gB = new GridBackground();

            gB.StretchToParentSize();

            Insert(0, gB);
        }

        #endregion

        #region Utilities
        public Vector2 GetLocalMousePosition(Vector2 mousePosition, bool isSearchWindow = false)
        {

            Vector2 worldMousePosition = mousePosition;

            if(isSearchWindow )
            {
                worldMousePosition -= editorwindow.position.position;
            }

            Vector2 localMousePosition = contentViewContainer.WorldToLocal(worldMousePosition);

            return localMousePosition;
        }
        #endregion
    }
}