using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class FireGrid : MonoBehaviour {

   
    public int selGridInt = 0;
    public string[] selStrings = new string[] { "A1", "B1", "C1", "D1", "E1", "F1", "A2", "B2", "C2", "D2", "E2",
                                                "F2", "A3", "B3", "C3", "D3", "E3", "F3", "A4", "B4", "C4", "D4", "E4", "F4",
                                                 "A5", "B5", "C5", "D5", "E5", "F5", "A6", "B6", "C6", "D6", "E6", "F6"};
    public string[] selStrings1 = new string[] { "A1", "A2", "A3", "A4", "A5", "A6" };

    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 100,1000,1000));
        //   GUILayout.BeginVertical("Box");
        // selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, 2, GUILayout.Width(20));
        selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, 6, GUILayout.Width(200));
        if (GUILayout.Button("FIRE", GUILayout.Width(50)))
            // Debug.Log("You chose " + selStrings[selGridInt]);
            SceneManager.LoadScene("fireScene");
        GUILayout.EndArea();
       // GUILayout.EndVertical();
     
    }

}
