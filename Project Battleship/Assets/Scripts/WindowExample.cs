using UnityEngine;
using System.Collections;

public class WindowExample : MonoBehaviour {
    public Rect windowRect = new Rect(40, 200, 120, 50);
    void OnGUI() {
        windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");

    }
    void DoMyWindow(int windowID) {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Okay"))
            print("Got a click");

    }
}
