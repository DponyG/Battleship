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

    public CreateKVP() {

    }

    public void CreateFriendlyKVP(string selString) {

       
        var result = Regex.Replace(selString, @"\D", "");
        var number = 0;
        bool attemptParse = System.Int32.TryParse(result, out number);
        if (attemptParse) {
            number = System.Int32.Parse(result);
            
            if (selString.Trim().StartsWith("A")) {
                kvpF.Add(selString, new Vector3(5.0f, 0.0f, -((10*number)-5.0f)));
            }

            else if (selString.Trim().StartsWith("B")) {
                kvpF.Add(selString, new Vector3(15.0f, 0.0f, -((10*number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("C")) {
                kvpF.Add(selString, new Vector3(25.0f, 0.0f, -((10*number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("D")) {
                kvpF.Add(selString, new Vector3(35.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("E")) {
                kvpF.Add(selString, new Vector3(45.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("F")) {
                kvpF.Add(selString, new Vector3(55.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("G")) {
                kvpF.Add(selString, new Vector3(65.0f, 0.0f, -((10 * number) - 5.0f)));
            }

            else if (selString.Trim().StartsWith("H")) {
                kvpF.Add(selString, new Vector3(75.0f, 0.0f, -((10 * number) - 5.0f)));
            } 
            
            else if (selString.Trim().StartsWith("I")) {
                kvpF.Add(selString, new Vector3(85.0f, 0.0f, -((10 * number) - 5.0f)));
            } 
            else 
                kvpF.Add(selString, new Vector3(95.0f, 0.0f, -((10 * number) - 5.0f)));
            
        }

    }

    public void CreateEnemyKVP(string selString) {


        var result = Regex.Replace(selString, @"\D", "");
        var number = 0;
        bool attemptParse = System.Int32.TryParse(result, out number);
        if (attemptParse) {
            number = System.Int32.Parse(result);

            if (selString.Trim().StartsWith("A")) {
                kvpE.Add(selString, new Vector3(115.0f, 0, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("B")) {
                kvpE.Add(selString, new Vector3(125.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("C")) {
                kvpE.Add(selString, new Vector3(135.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("D")) {
                kvpE.Add(selString, new Vector3(145.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("E")) {
                kvpE.Add(selString, new Vector3(155.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("F")) {
                kvpE.Add(selString, new Vector3(165.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("G")) {
                kvpE.Add(selString, new Vector3(175.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("H")) {
                kvpE.Add(selString, new Vector3(185.0f, 0.0f, -((10 * number) - 5.0f)));
            } else if (selString.Trim().StartsWith("I")) {
                kvpE.Add(selString, new Vector3(195.0f, 0.0f, -((10 * number) - 5.0f)));
            } else
                kvpE.Add(selString, new Vector3(205.0f, 0.0f, ((10 * number) - 5.0f)));

        }

    }



    public Dictionary<string, Vector3> GetKVPF() {
        return kvpF;
    }

    public Dictionary<string, Vector3> GetKVPE() {
        return kvpE;
    }

    public Vector3 GetValueF(string key) {
        return kvpF[key];
    }

    public Vector3 GetValueE(string key) {
        return kvpE[key];
    }



    public Dictionary<string, Vector3> kvpF = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> kvpE = new Dictionary<string, Vector3>();


}

 







