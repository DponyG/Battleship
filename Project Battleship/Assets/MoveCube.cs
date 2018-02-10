using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
    public GameObject cubeprefab;
    int width = 11;
    int height = 11;

    // Use this for initialization
    void Start() {

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                Instantiate(cubeprefab, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
    }
}
          

        

        
		
	
