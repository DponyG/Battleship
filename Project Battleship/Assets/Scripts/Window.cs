using UnityEngine;
using System.Collections;

public class Window : MonoBehaviour {

    public int selGridInt = 0;
    public int selSearchInt = 0;
    public string[] selStrings = new string[] { "Grid 1", "Grid 2", "Grid 3", "Grid 4" };
    void OnGUI() {
        selGridInt = GUI.SelectionGrid(new Rect(25, 25, 100, 30), selGridInt, selStrings, 2);
        if (selSearchInt == 0) {
            // execute code
        } else if (selGridInt == 1) {
            // execute code
        } else if (selGridInt == 2) {
            // execute code
        } else if (selGridInt == 3) {
            // execute code
        }
    }

}
