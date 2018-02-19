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



    public CreateKVP(string selString) {

       
        var result = Regex.Replace(selString, @"\D", "");
        var number = 0;
        bool attemptParse = System.Int32.TryParse(result, out number);
        if (attemptParse) {
            number = System.Int32.Parse(result);
            
            if (selString.Trim().StartsWith("A")) {
                kvp.Add(selString, new Vector3(5.0f, 0.0f, -((10*number)-5.0f)));
            }

            else if (selString.Trim().StartsWith("B")) {
                kvp.Add(selString, new Vector3(15.0f, 0.0f, -((10*number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("C")) {
                kvp.Add(selString, new Vector3(25.0f, 0.0f, -((10*number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("D")) {
                kvp.Add(selString, new Vector3(35.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("E")) {
                kvp.Add(selString, new Vector3(45.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("F")) {
                kvp.Add(selString, new Vector3(55.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("G")) {
                kvp.Add(selString, new Vector3(65.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("H")) {
                kvp.Add(selString, new Vector3(75.0f, 0.0f, -((10 * number) - 5.0f)));
            } 
            
            else if (selString.Trim().StartsWith("I")) {
                kvp.Add(selString, new Vector3(85.0f, 0.0f, -((10 * number) - 5.0f)));
            } 
            else 
                kvp.Add(selString, new Vector3(95.0f, 0.0f, -((10 * number) - 5.0f)));
            
        }

    }

    public Dictionary<string, Vector3> GetKVP() {
        return kvp;
    }
      
        

    public Dictionary<string, Vector3> kvp = new Dictionary<string, Vector3>();
  

}

 







