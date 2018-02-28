
using UnityEngine;

public class LoadSceneButton : MonoBehaviour {

	public void LoadScene() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("BattleShip");
    }
	
}
