
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour {

	void Update () {
        if (Time.timeSinceLevelLoad > 5) {
            SceneManager.LoadScene("BattleShip");
        }
    }
}
