using System;
using UnityEngine;



public class PersistanceFriendly : MonoBehaviour {


    public static PersistanceFriendly friendly;
    public enum State { User, Fire, Computer };

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

    //Start Function Instantiates all objects.
    void Start() {
        Peral urPeral = new Peral();
        Fang urFang = new Fang();
    }
    //TODO is desroyed.....
}
