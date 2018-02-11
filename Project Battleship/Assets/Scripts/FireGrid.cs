using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FireGrid : MonoBehaviour {

   
    public int selGridInt = 0;
    public string[] selStrings = new string[] { "A1", "A2", "A3" };

    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 240, 100, 100));
        var kvpArr = new List<KeyValuePair<string[], Vector3>>();
        selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, 1, GUILayout.Width(30));
        if (GUILayout.Button("FIRE", GUILayout.Width(50)))
            Debug.Log("You chose " + selStrings[selGridInt]);
        GUILayout.EndArea();
    }
}
