using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Windows
{
    using Utility;
    using Windows;
    using Enumeration;
    public class DSEditorWindow : EditorWindow
    {
        /*[SerializeField]
        private StyleSheet m_StyleSheet = default;*/

        [MenuItem("Window/DS/DSEditorWindow")]
        public static void ShowExample()
        {
            GetWindow<DSEditorWindow>("Dialogue Graph");
        }

        private void OnEnable()
        {
            AddGraphView();

            AddStyles();
        }
        #region Elements addition
        private void AddStyles()
        {
            rootVisualElement.AddStyleSheets("DialogueSystem/DSVariables.uss");
        }

        private void AddGraphView()
        {
            DSGraphView gV = new DSGraphView(this);

            gV.StretchToParentSize();

            rootVisualElement.Add(gV);
        }
    }
    #endregion

}