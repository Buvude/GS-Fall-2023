using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Utility
{
    public static class DSStyleUtility
    {
        public static VisualElement AddClasses(this VisualElement element, params string[] classNames)
        {
            foreach (string className in classNames) 
            {
                element.AddToClassList(className);
            }

            return element; 
        }
        public static VisualElement AddStyleSheets(this VisualElement element, params string[] styleNames) 
        {
            foreach (string styleSheetNames in styleNames) 
            {
                StyleSheet sS2 = (StyleSheet)EditorGUIUtility.Load(styleSheetNames);
                element.styleSheets.Add(sS2);
            }
            return element;
        }
    }
}

