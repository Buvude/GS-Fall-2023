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
    using Data.Error;
    using Unity.VisualScripting;

    public class DSGraphView : GraphView
    {
        //private VisualElement contentViewContainer = new VisualElement();

        private DSEditorWindow editorwindow;
        private DSSearchWindow searchWindow;

        private SerializableDictionary<string, DSNodeErrorData> ungroupedNodes;
        private SerializableDictionary<string, DSGroupErrorData> groups;
        private SerializableDictionary<Group, SerializableDictionary<string, DSNodeErrorData>> groupedNodes;

        public DSGraphView(DSEditorWindow window)
        {
            ungroupedNodes=new SerializableDictionary<string, DSNodeErrorData> ();
            groups=new SerializableDictionary<string, DSGroupErrorData> ();
            groupedNodes=new SerializableDictionary<Group, SerializableDictionary<string, DSNodeErrorData>> ();

            AddManipulators();
            AddSearchWindow();
            AddGridBackground();

            OnElementDeleted();
            OnGroupElementsAdded();
            OnGroupElementsRemeoved();
            OnGroupRenamed();


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

        public DSGroup CreateGroup(string Title, Vector2 localMousePosition)
        {
            DSGroup group = new DSGroup(Title, localMousePosition);

            AddGroup(group);

            return group;


        }

        public DSNode createNodeActivator(DSDialogueType dT, Vector2 position)
        {
            return CreateNode(dT, position);

        }
        public DSNode CreateNode(DSDialogueType dT, Vector2 position)
        {
            Type nodeType = Type.GetType($"DS.Elements.DS{dT}");

            DSNode node = (DSNode)Activator.CreateInstance(nodeType);

            node.Initialize(this,position);
            node.Draw();

            AddUngroupedNode(node);

            return node;
        }
        #endregion
        #region Callbacks
        private void OnElementDeleted()
        {
            deleteSelection = (operationName, AskUser) =>
            {
                Type groupType=typeof(DSGroup);
                List<DSGroup> groupsToDelete = new List<DSGroup>();
                List<DSNode> nodesToDelete=new List<DSNode>();
                foreach(GraphElement element in selection)
                {
                    if(element is DSNode node)
                    {
                        nodesToDelete.Add(node);

                        continue;
                    }

                    if(element.GetType()!=groupType)
                    {
                        continue;
                    }

                    DSGroup group = (DSGroup)element;

                    RemoveGroup(group);

                    groupsToDelete.Add(group);
                }

                foreach(DSGroup group in groupsToDelete)
                {
                    RemoveElement(group);
                }
                foreach(DSNode node in nodesToDelete)
                {
                    if (node.Group != null)
                    {
                        node.Group.RemoveElement(node);
                    }
                    removeUngroupedNode(node);

                    RemoveElement(node);
                }
            };
        }

        

        private void OnGroupElementsAdded()
        {
            elementsAddedToGroup = (group, elements) =>
            {

                foreach (GraphElement element in selection)
                {
                    if (!(element is DSNode))
                    {
                        continue;
                    }

                    DSGroup nodeGroup= (DSGroup)group;
                    DSNode node= (DSNode)element;

                    removeUngroupedNode(node);
                    AddGroupedNode(node,nodeGroup);
                }
            };
        }

        private void OnGroupRenamed()
        {
            groupTitleChanged = (group, newTitle) =>
            {
                DSGroup dSGroup= (DSGroup)group;

                RemoveGroup(dSGroup);

                dSGroup.oldTitle = newTitle;

                AddGroup(dSGroup);
            };
        }

        private void OnGroupElementsRemeoved()
        {
            elementsRemovedFromGroup = (group, elements) =>
            {
                foreach (GraphElement element in selection)
                {
                    if (!(element is DSNode))
                    {
                        continue;
                    }

                    DSNode node = (DSNode)element;

                    RemoveGroupedNode(node, group);
                    AddUngroupedNode(node);
                }
            };
        }
        #endregion

        #region Repeated Elements
        public void AddUngroupedNode(DSNode node)
        {
            string nodeName = node.DialogueName;

            if(!ungroupedNodes.ContainsKey(nodeName))
            {
                DSNodeErrorData nodeErrorData = new DSNodeErrorData();

                nodeErrorData.Nodes.Add(node);

                ungroupedNodes.Add(nodeName, nodeErrorData);

                return;
            }

            List<DSNode> ungroupedNodesList = ungroupedNodes[nodeName].Nodes;
            ungroupedNodesList.Add(node);

            Color errorColor = ungroupedNodes[nodeName].ErrorData.Color;

            node.setErrorStyle(errorColor);

            if (ungroupedNodesList.Count == 2)
            {
                ungroupedNodesList[0].setErrorStyle(errorColor);
            }
        }

        public void removeUngroupedNode(DSNode node)
        {
            string nodeName=node.DialogueName;
            
            List<DSNode> ungroupedNodesList = ungroupedNodes[nodeName].Nodes;

            ungroupedNodesList.Remove(node);

            node.resetStyle();

            if (ungroupedNodesList.Count == 1)
            {
                ungroupedNodesList[0].resetStyle();
            }

            if (ungroupedNodesList.Count == 0)
            {
                ungroupedNodes.Remove(nodeName);
            }
        }

        public void AddGroup(DSGroup group)
        {
            string groupName = group.title;

            if(!groups.ContainsKey(groupName))
            {
                DSGroupErrorData groupErrorData = new DSGroupErrorData();

                groupErrorData.Groups.Add(group);

                groups.Add(groupName, groupErrorData);

                return;
            }

            List<DSGroup> groupsList = groups[groupName].Groups;

            groupsList.Add(group);

            Color errorColor = groups[groupName].ErrorData.Color;

            group.setErrorStyle(errorColor);

            if(groupsList.Count==2)
            {
                groupsList[0].setErrorStyle(errorColor);
            }
        }

        public void RemoveGroup(DSGroup group)
        {
            string oldGroupName = group.oldTitle;

            List<DSGroup> groupsList = groups[oldGroupName].Groups;

            groupsList.Remove(group);

            group.resetStyle();

            if (groupsList.Count == 1)
            {
                groupsList[0].resetStyle();
            }

            if(groupsList.Count == 0) 
            {
                groups.Remove(oldGroupName);
            
            }
        }

        public void AddGroupedNode(DSNode node, DSGroup group)
        {
            string nodeName = node.DialogueName;

            node.Group = group;

            if (!groupedNodes.ContainsKey(group))
            {
                groupedNodes.Add(group, new SerializableDictionary<string, DSNodeErrorData>());
            }

            if (!groupedNodes[group].ContainsKey(nodeName))
            {
                DSNodeErrorData nodeErrorData = new DSNodeErrorData();

                nodeErrorData.Nodes.Add(node);

                groupedNodes[group].Add(nodeName, nodeErrorData);

                return;
            }

            List<DSNode> groupedNodesList = groupedNodes[group][nodeName].Nodes;

            groupedNodesList.Add(node);

            Color errorColor = groupedNodes[group][nodeName].ErrorData.Color;

            node.setErrorStyle(errorColor);

            if (groupedNodesList.Count == 2)
            {
                groupedNodesList[0].setErrorStyle(errorColor);
            }
        }

        public void RemoveGroupedNode(DSNode node, Group group)
        {
            string nodeName = node.DialogueName;

            node.Group = null;

            List<DSNode> groupedNodesList = groupedNodes[group][nodeName].Nodes;

            groupedNodesList.Remove(node);

            node.resetStyle();

            if (groupedNodesList.Count > 0)
            {
                groupedNodesList[0].resetStyle();

                return;
            }

            if (groupedNodesList.Count == 0)
            {
                groupedNodes[group].Remove(nodeName);

                if (groupedNodes[group].Count == 0)
                {
                    groupedNodes.Remove(group);
                }
            }
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