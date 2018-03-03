using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireGrid : MonoBehaviour {

  
    private int selGridInt = 0;
    private Quaternion rotation;



    public GameObject prefabMissile;



    void Start() {
        rotation.eulerAngles = new Vector3(90, 0, 0); 
        Persistance.ChangeState(Persistance.States.User);
        Persistance.perData.urFire = false; // This is set to false because we wait for all the ships to be placed.

    }

    private bool toggleTxt = false;
    void OnGUI() {


        toggleTxt = GUI.Toggle(new Rect(1225, 0, 100, 30), toggleTxt, "ToggleFire");
      

        if (toggleTxt) {


            GUILayout.BeginArea(new Rect(1225, 30, 3000, 3000));
            selGridInt = GUILayout.SelectionGrid(selGridInt, Persistance.perData.selStrings, 10, GUILayout.Width(300));
            Persistance.perData.SetFireIndex(selGridInt);
          
            if (Persistance.perData.selStrings[selGridInt] != "X" && Persistance.perData.selStrings[selGridInt] != "O") {
                CreateKVP kvp = new CreateKVP();
                kvp.CreateEnemyKVP(Persistance.perData.selStrings[selGridInt]);

              

                //If Fire is selected and is the user state + its your turn to fire create a new missile.
                //TODO refactor that if statement into a function
                if (GUILayout.Button("FIRE", GUILayout.Width(50)) && Persistance.IsState(Persistance.States.User) && Persistance.perData.urFire) {
                    Persistance.perData.urFire = false;
                    Persistance.perData.SetMissileCoord(kvp.GetValueE(Persistance.perData.selStrings[selGridInt]));
                   
                    Instantiate(prefabMissile, new Vector3(0, 300, 0), rotation);
                  

                }
            }
            GUILayout.EndArea();
        }
    }
}









