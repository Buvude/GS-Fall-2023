using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using UnityEngine.UIElements;

public class DSGraphView : GraphView
{
    public DSGraphView()
    {
        AddGridBackground();
    }

    private void AddGridBackground()
    {
        GridBackground gB = new GridBackground();

        gB.StretchToParentSize();

        Insert(0, gB);
    }
}
