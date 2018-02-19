using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireGrid : MonoBehaviour {

    public static FireGrid control;
    public int selGridInt = 0;
   
    
    void OnGUI() {
        GUILayout.BeginArea(new Rect(20, 100, 2000, 2000));

        selGridInt = GUILayout.SelectionGrid(selGridInt, Persistance.perData.selStrings, 10, GUILayout.Width(400));
        if (Persistance.perData.selStrings[selGridInt]!= "X" && Persistance.perData.selStrings[selGridInt] != "O") {
            CreateKVP kvp = new CreateKVP(Persistance.perData.selStrings[selGridInt]);
            Persistance.perData.coord = kvp.GetKVP()[Persistance.perData.selStrings[selGridInt]]; //This sets the coord = to the item selected in the gui
            Persistance.perData.index = selGridInt;
            if (GUILayout.Button("FIRE", GUILayout.Width(50))) {
                SceneManager.LoadScene("fireScene");
            }
        }
        GUILayout.EndArea();

    }


 
}
