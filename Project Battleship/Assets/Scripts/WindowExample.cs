﻿using UnityEngine;
using System.Collections;

public class WindowExample : MonoBehaviour {

    public GameObject win = GameObject.Find("Window");
    public Rect windowRect = new Rect(40, 200, 120, 50);
    void OnGUI() {
        windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");
        DontDestroyOnLoad(win);
    }
    void DoMyWindow(int windowID) {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Okay"))
            print("Got a click");

    }
}
