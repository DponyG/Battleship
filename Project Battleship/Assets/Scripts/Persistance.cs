using System;
using UnityEngine;



public class Persistance : MonoBehaviour {

    public static Persistance friendly;
    // public static FireGrid control;
    public Vector3 coord;
    public enum State { User, Fire, Computer };
    public string[] selStrings = new string[] { "A1", "B1", "C1", "D1", "E1", "F1", "A2", "B2", "C2", "D2", "E2",
                                                "F2", "A3", "B3", "C3", "D3", "E3", "F3", "A4", "B4", "C4", "D4", "E4", "F4",
                                                 "A5", "B5", "C5", "D5", "E5", "F5", "A6", "B6", "C6", "D6", "E6", "F6", "X"};

    //Allows us to keep this GameObject upon switching scenes.
    //All other GameObjects of the same type will be destroyed.
    private void Awake() {
        if (friendly == null) {
            DontDestroyOnLoad(gameObject);
            friendly = this;
        } else if (friendly != this) {
            Destroy(gameObject);
        }
    }
    //Puts the Coordinates in a persistance state

    public void UpdateString() {

    }

    //Start Function Instantiates all objects.
    void Start() {
        Peral urPeral = new Peral();
        Fang urFang = new Fang();
    }
    //TODO is desroyed.....
}
