using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

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
    }

    private void AddGraphView()
    {
        DSGraphView gV = new DSGraphView();

        gV.StretchToParentSize();

        rootVisualElement.Add(gV);
    }
}
