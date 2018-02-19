
using UnityEngine;

public class DestroyPeral : MonoBehaviour {

	// Destroys the cpu's Peral if its isDestroyed bool is set to true
	void Update () {
        if (Persistance.perData.cpuPeral.GetStatus())
        Destroy(this.gameObject);
	}
}
