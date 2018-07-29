﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObstaclesGenerator))]
public class ObstaclesGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Regenerate Obstacles"))
            Script.GenerateObstacles();
        if (GUILayout.Button("Remove Obstacles"))
            Script.RemoveObstacles();
    }

    public ObstaclesGenerator Script
    {
        get
        {
            return (ObstaclesGenerator)target;
        }
    }

    private void RegenerateObstacles()
    {
    }
}
