using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


public class CreateKVP  {

    /*CreateKVPS
     *Default Constructor
     * Preconditions:
     * This function must take a string[] of a value > 0
     * Postconditions:
     * Creates a kvp dictionary with the string elements in the array
     * as a key, and a Vector3d position as a value
     */

   public float xA = 10.0f;
   public float xB = 10.0f;
   public float zB = 10.0f;

    public CreateKVP(string selString) {

       
        var result = Regex.Replace(selString, @"\D", "");
        var parse = System.Int32.Parse(result);

        if (selString.Trim().StartsWith("A")) {
            kvp.Add(selString, new Vector3(10.0f, 0.0f, parse*10.0f));
        }

        if (selString.Trim().StartsWith("B")) {
            kvp.Add(selString, new Vector3(20.0f, 0.0f, parse*10.0f));
        }




    }

    public Dictionary<string, Vector3> GetKVP() {
        return kvp;
    }
      
        

    public Dictionary<string, Vector3> kvp = new Dictionary<string, Vector3>();
    //public string[] selStrings = new string[] { "A1", "A2", "A3", "A4" ,"A5", "A6",
    //"B1", "B2", "B3", "B4","B5" };
    //public Vector3[] setVector = new Vector3[] { new Vector3(0.0f, 0.0f, 0.0f),
    //new Vector3(10.0f, 0.0f, 0.0f), new Vector3(20.0f, 0.0f, 0.0f)};
   


}

 







