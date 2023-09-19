using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Windows
{
    public class DSGraphWindow : EditorWindow
    {
        /*[SerializeField]
        private StyleSheet m_StyleSheet = default;*/

        [MenuItem("Window/DS/DSGraphWindow")]
        public static void ShowExample()
        {
            GetWindow<DSGraphWindow>("Dialogue Graph");
        }

        private void OnEnable()
        {
            AddGraphView();

            AddStyles();
        }
        #region Elements addition
        private void AddStyles()
        {
            StyleSheet sS = (StyleSheet)EditorGUIUtility.Load("DialogueSystem/DSVariables.uss");

            rootVisualElement.styleSheets.Add(sS);
        }

        private void AddGraphView()
        {
            DSGraphView gV = new DSGraphView();

            gV.StretchToParentSize();

            rootVisualElement.Add(gV);
        }
    }
    #endregion

}