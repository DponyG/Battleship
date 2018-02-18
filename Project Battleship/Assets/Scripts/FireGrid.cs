using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireGrid : MonoBehaviour {

    public static FireGrid control;
    public int selGridInt = 0;
   
    
    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 100, 1000, 1000));

        selGridInt = GUILayout.SelectionGrid(selGridInt, Persistance.friendly.selStrings, 6, GUILayout.Width(200));
        if (Persistance.friendly.selStrings[selGridInt]!= "X" && Persistance.friendly.selStrings[selGridInt] != "0") {
            CreateKVP kvp = new CreateKVP(Persistance.friendly.selStrings[selGridInt]);
            Persistance.friendly.coord = kvp.GetKVP()[Persistance.friendly.selStrings[selGridInt]]; //This sets the coord = to the item selected in the gui
            if (GUILayout.Button("FIRE", GUILayout.Width(50))) {
                SceneManager.LoadScene("fireScene");
            }
        }
        if (GUILayout.Button("TEST", GUILayout.Width(50)))
            // Debug.Log("You chose " + selStrings[selGridInt]);
            SceneManager.LoadScene("BattleShip");
        GUILayout.EndArea();

    }


 
}
