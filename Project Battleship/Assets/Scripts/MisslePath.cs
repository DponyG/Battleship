using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisslePath : MonoBehaviour {

    public Transform clone;
    public Transform target;
    public float speed;
    void Start() {

    clone = Instantiate(target, FireGrid.control.GetCoord(), Quaternion.identity);
    print(FireGrid.control.GetCoord());
        

    }
    void Update() {



      

     print(clone.position);
     print(FireGrid.control.GetCoord());
     float step = speed * Time.deltaTime;
     transform.position = Vector3.MoveTowards(transform.position, clone.position, step);
    }

}
