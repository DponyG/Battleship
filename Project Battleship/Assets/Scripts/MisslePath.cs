
using UnityEngine;
using UnityEngine.SceneManagement;

public class MisslePath : MonoBehaviour {

    public Transform clone;
    public Transform target;
    public float speed;
    void Start() {

    clone = Instantiate(target, Persistance.friendly.coord, Quaternion.identity);
    print(Persistance.friendly.coord);
        

    }
    void Update() {
     print(clone.position);
     print(Persistance.friendly.coord);
     float step = speed * Time.deltaTime;
     transform.position = Vector3.MoveTowards(transform.position, clone.position, step);

        
    }

}
