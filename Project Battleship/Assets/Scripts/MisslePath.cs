
using UnityEngine;


//MissilePath
//Missile moves to the Persistance.perData.GetMissileCoord
public class MisslePath : MonoBehaviour {
  

    void Start() {
        Persistance.perData.cpuFire = false;
    }
  
    public float speed;
    void Update() {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Persistance.perData.GetMissileCoord(), step);
        if (transform.position == Persistance.perData.GetMissileCoord()) {
            if (Persistance.IsState(Persistance.States.User)) {
                Persistance.perData.selStrings[Persistance.perData.GetFireIndex()] = "O";
                Persistance.ChangeState(Persistance.States.Computer);
                Persistance.perData.cpuFire = true;
            } else {
                Persistance.perData.placeShips[Persistance.perData.GetShipIndex()] = "O";
                Persistance.perData.urFire = true;
                Persistance.ChangeState(Persistance.States.User);
            }
            Destroy(this.gameObject);
        }
    }
}



    


