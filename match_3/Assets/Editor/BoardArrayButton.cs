using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Match3))]
public class BoardArrayButton : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Match3 game = (Match3)target; 

        if (GUILayout.Button("Reset Board Array")) { game.ResetBoardArray(); }
    }
}
