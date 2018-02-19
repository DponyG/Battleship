using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;




public class PersistanceEnemy : MonoBehaviour {

    public static PersistanceEnemy enemy;
    public enum State { User, Fire, Computer };

    //Allows us to keep this GameObject upon switching scenes.
    //All other GameObjects of the same type will be destroyed.
    private void Awake() {
        if (enemy == null) {
            DontDestroyOnLoad(gameObject);
            enemy = this;
        } else if (enemy != this) {
            Destroy(gameObject);
        }
    }


    //Start Function Instantiates all objects.
    void Start() {
        Peral cpuPeral = new Peral();
        Fang cpuFang = new Fang();
    }
    //TODO is desroyed.....
}
