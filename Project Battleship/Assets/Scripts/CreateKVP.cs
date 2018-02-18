using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using System;


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
        var number = 0;
        bool attemptParse = System.Int32.TryParse(result, out number);

        if (attemptParse) {
            number = System.Int32.Parse(result);
            Console.WriteLine(number);
            if (selString.Trim().StartsWith("A")) {
                kvp.Add(selString, new Vector3(10.0f, 0.0f,  (number+1)*10.0f));
            }

            if (selString.Trim().StartsWith("B")) {
                kvp.Add(selString, new Vector3(20.0f, 0.0f, (number+1)*10.0f));
            }

            if (selString.Trim().StartsWith("C")) {
                kvp.Add(selString, new Vector3(0.0f, -1000.0f, 0.0f));
            }
        }

    }

    public Dictionary<string, Vector3> GetKVP() {
        return kvp;
    }
      
        

    public Dictionary<string, Vector3> kvp = new Dictionary<string, Vector3>();
  

}

 







