
using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {

    public GameObject largeExplosion;
    public GameObject smallExplosion;


    void OnCollisionEnter(Collision col) {
        Instantiate(smallExplosion, transform.position, Quaternion.identity);

        if (col.gameObject.tag == "cpuStarship") {
            Persistance.perData.cpuStarship.hitCount();
            if (Persistance.perData.cpuStarship.GetHp() == 0) {
                Persistance.perData.IncrementShipDestroyed();
                Instantiate(largeExplosion, transform.position, Quaternion.identity);
                Destroy(col.gameObject);
            }

        } else if (col.gameObject.tag == "cpuFreighter") {
            Persistance.perData.cpuFreighter.hitCount();
            if (Persistance.perData.cpuFreighter.GetHp() == 0) {
                Persistance.perData.IncrementShipDestroyed();
                Destroy(col.gameObject);
            }

        } else if (col.gameObject.tag == "cpuCarrier") {
            Persistance.perData.cpuCarrier.hitCount();
            if (Persistance.perData.cpuCarrier.GetHp() == 0) {
                Persistance.perData.IncrementShipDestroyed();
                Destroy(col.gameObject);
            }

        } else if (col.gameObject.tag == "cpuVoyager") {
            Persistance.perData.cpuVoyager.hitCount();
            if (Persistance.perData.cpuVoyager.GetHp() == 0) {
                Persistance.perData.IncrementShipDestroyed();
                Destroy(col.gameObject);
            }

        } else if (col.gameObject.tag == "urStarship") {
            Persistance.perData.urStarship.hitCount();
            if (Persistance.perData.urStarship.GetHp() == 0) {
                Persistance.perData.IncrementShipLost();
                Destroy(col.gameObject);
            }


        } else if (col.gameObject.tag == "urFreighter") {
            Persistance.perData.urFreighter.hitCount();
            if (Persistance.perData.urFreighter.GetHp() == 0) {
                Persistance.perData.IncrementShipLost();
                Destroy(col.gameObject);
            }
        } else if (col.gameObject.tag == "urCarrier") {
            Persistance.perData.urCarrier.hitCount();
            if (Persistance.perData.urCarrier.GetHp() == 0) {
                Persistance.perData.IncrementShipLost();
                Destroy(col.gameObject);
            }

        } else {
            Persistance.perData.urVoyager.hitCount();
            if (Persistance.perData.urVoyager.GetHp() == 0) {
                Persistance.perData.IncrementShipLost();
                Destroy(col.gameObject);
            }

        }

        if (Persistance.IsState(Persistance.States.User)) {
            Persistance.perData.selStrings[Persistance.perData.GetFireIndex()] = "X";
            Persistance.ChangeState(Persistance.States.Computer);
            Persistance.perData.cpuFire = true;
        } else {
            Persistance.perData.placeShips[Persistance.perData.GetShipIndex()] = "X";
            Persistance.perData.urFire = true;
            Persistance.ChangeState(Persistance.States.User);


        }
        Destroy(this.gameObject);
    }
}










