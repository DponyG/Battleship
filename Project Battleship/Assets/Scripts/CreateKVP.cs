using System.Collections.Generic;
using UnityEngine;


public class CreateKVP : MonoBehaviour {

    /*CreateKVPS
     *Default Constructor
     * Preconditions:
     * This function must take a string[] of a value > 0
     * Postconditions:
     * Creates a kvp dictionary with the string elements in the array
     * as a key, and a Vector3d position as a value
     */

   public float xA = 0.0f;
   public float xB = 0.0f;
   public float zB = 10.0f;

    public CreateKVP(string[] selString) { 

       
        foreach (var element in selStrings) {
            if (element.Trim().StartsWith("A")) {
                kvp.Add(element, new Vector3(xA, 0.0f, 0.0f));
                xA += 10.0f;
            }

            if (element.Trim().StartsWith("B")) {
                kvp.Add(element, new Vector3(xB, 0.0f, zB));
                xB += 10.0f;
                zB += 10.0f;
            }
        }
    }

    public Dictionary<string, Vector3> GetKVP() {
        return kvp;
    }
      
        

    public Dictionary<string, Vector3> kvp = new Dictionary<string, Vector3>();
    public string[] selStrings = new string[] { "A1", "A2", "A3", "A4" ,"A5", "A6",
    "B1", "B2", "B3", "B4","B5" };
    public Vector3[] setVector = new Vector3[] { new Vector3(0.0f, 0.0f, 0.0f),
    new Vector3(10.0f, 0.0f, 0.0f), new Vector3(20.0f, 0.0f, 0.0f)};
   


}

 







