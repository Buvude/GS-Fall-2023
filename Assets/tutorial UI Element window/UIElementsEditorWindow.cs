using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System;

public class UIElementsEditorWindow : EditorWindow
{/*
    [SerializeField]
    private StyleSheet m_StyleSheet = default;*/

    [MenuItem("Window/UI Toolkit/UIElementsEditorWindow")]
    public static void ShowExample()
    {
        UIElementsEditorWindow wnd = GetWindow<UIElementsEditorWindow>();
        wnd.titleContent = new GUIContent("UIElementsEditorWindow");
    }

    public void CreateGUI()
    {
        VisualElement container = new VisualElement();
        rootVisualElement.Add(container);

        StyleSheet styleSheet = (StyleSheet)EditorGUIUtility.Load("UIElementsEditorStyles.uss");

        rootVisualElement.styleSheets.Add(styleSheet);
        
        
        Label title = new Label("Color Picker");
        ColorField cF = new ColorField();
        cF.name = "CP";

    container.Add(title);
        container.Add(cF);

        VisualElement buttonsContainer = new VisualElement();

        

        Button RandomColorbtn = (Button)CreateButton("Random Color");
        Button ResetColorbtn = (Button)CreateButton("Reset Color");
        Button CopyColorbtn = (Button)CreateButton("Copy Color");
        Button PasteColorbtn = (Button)CreateButton("Paste Color");

        buttonsContainer.Add(RandomColorbtn);
        buttonsContainer.Add(ResetColorbtn);
        buttonsContainer.Add(CopyColorbtn);
        buttonsContainer.Add(PasteColorbtn);

        container.Add(buttonsContainer);
        buttonsContainer.AddToClassList("horizontal-container");
        RandomColorbtn.AddToClassList("dark-button");
        ResetColorbtn.AddToClassList("dark-button");
        CopyColorbtn.AddToClassList("dark-button");
        PasteColorbtn.AddToClassList("dark-button");

        /*Debug.Log(container.panel);
        Debug.Log(rootVisualElement.panel);*/
    }
    private VisualElement CreateButton(string btnText)
    {
        return new Button() { text = btnText };
    }
}
