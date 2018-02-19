
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
            isHit = true;
            Persistance.perData.cpuPeral.TakeDamage();

        }

        if (isHit) {
            Persistance.perData.UpdateString(hit);
        }


        Destroy(this.gameObject);

    }

    void Update() {
        if (!isHit && Time.timeSinceLevelLoad > 4) {
            Persistance.perData.UpdateString(missed);
        }
    }
}






        //    if (col.gameObject.name == "black_perl") {
        //        Destroy(col.gameObject);
        //        isHit = true;
        //    }

        //    Destroy(this.gameObject);
       


