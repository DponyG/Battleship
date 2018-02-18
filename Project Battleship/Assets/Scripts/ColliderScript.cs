using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a ColliderScript and should be attatched to the missle
//object. It checks to see if the object collided is a gameobject
//and if so destroys it.
public class ColliderScript : MonoBehaviour {
    public GameObject explosion;

    public bool isHit = false;
    const string hit = "X";
    const string missed = "O";
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "cpuPerl") {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(col.gameObject);
        }

        Destroy(this.gameObject);
    }
}




        //    if (col.gameObject.name == "black_perl") {
        //        Destroy(col.gameObject);
        //        isHit = true;
        //    }

        //    Destroy(this.gameObject);
       


