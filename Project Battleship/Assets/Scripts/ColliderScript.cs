using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "prop_powerCube") {
            Destroy(col.gameObject);
        }
    }
}
