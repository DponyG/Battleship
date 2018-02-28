using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ShipGrid 
//ShipGrid controls the placement of ships
//TODO Change totalships to ships2Place
public class ShipGrid : MonoBehaviour {

    public GameObject prefabCarrier;
    public GameObject prefabStarship;
    public GameObject prefabVoyager;
    public GameObject prefabFreighter;

    private GameObject carrier;
    private GameObject starShip;
    private GameObject voyager;
    private GameObject voyager2;
    private GameObject freighter;



    private string shipsLostString = "Ships Lost: ";
    private string shipsDestroyedString = "Ships Destroyed: ";
    private int selShipGridInt = 0;
    private Vector3 coord;
    private Vector3 rotate;
    private int totalShip = 5;
    private bool toggleTxt;

    // public Rect windowRect = new Rect(10, 20, 20, 20);







    void Start() {

        toggleTxt = false;

    }

    void OnGUI() {

        GUI.Label(new Rect(100, 0, 150, 40), shipsLostString + Persistance.perData.GetShipLost());
        GUI.Label(new Rect(200, 0, 150, 40), shipsDestroyedString + Persistance.perData.GetShipDestroyed());



        toggleTxt = GUI.Toggle(new Rect(0, 0, 100, 30), toggleTxt, "ToggleShip");


        if (toggleTxt) {
            GUILayout.BeginArea(new Rect(45, 30, 3000, 3000));



            selShipGridInt = GUILayout.SelectionGrid(selShipGridInt, Persistance.perData.placeShips, 10, GUILayout.Width(650), GUILayout.Height(600));
            if (GUILayout.Button("Rotate: " + rotate.y, GUILayout.Width(100))) {
                rotate.y = (rotate.y + 90) % 360;
            }
            if (GUILayout.Button("SetShip", GUILayout.Width(100))) {

                if (totalShip == 5) {

                    starShip = Instantiate(prefabStarship);
                    PlaceShip(30, rotate, Persistance.perData.placeShips[selShipGridInt], starShip);
                    // totalShip--;
                } else if (totalShip == 4) {

                    freighter = Instantiate(prefabFreighter);
                    PlaceShip(50, rotate, Persistance.perData.placeShips[selShipGridInt], freighter);
                    // totalShip--;
                } else if (totalShip == 3) {

                    carrier = Instantiate(prefabCarrier);
                    PlaceShip(40, rotate, Persistance.perData.placeShips[selShipGridInt], carrier);
                    // totalShip--;
                } else if (totalShip == 2) {

                    voyager = Instantiate(prefabVoyager);
                    PlaceShip(20, rotate, Persistance.perData.placeShips[selShipGridInt], voyager);
                    // totalShip--;
                } else if (totalShip == 1) {

                    voyager2 = Instantiate(prefabVoyager);
                    PlaceShip(20, rotate, Persistance.perData.placeShips[selShipGridInt], voyager2);
                    // totalShip--;
                    Persistance.perData.urFire = true;
                }
            }

            GUILayout.EndArea();
        }
    }

    //Placeship checks to see if the ship is to be placed in a valid location
    //If so placeship decements the placedship count
    //TODO clean up the if statements
    public void PlaceShip(int length, Vector3 rotation, string position, GameObject ship) {
        if(position == "S"){
            Destroy(ship);
            return;
        }
        int b;

        CreateKVP kvp = new CreateKVP();
        kvp.CreateFriendlyKVP(position);
        coord = kvp.GetValueF(position);
        ship.transform.position = (coord);
        ship.transform.Rotate(rotation);


        if (coord.x + length * Mathf.Cos(-rotation.y * Mathf.PI / 180) > 115.0f ||
            coord.x + length * Mathf.Cos(-rotation.y * Mathf.PI / 180) < -5.0f ||
            coord.z + length * Mathf.Sin(-rotation.y * Mathf.PI / 180) < -115.0f ||
            coord.z + length * Mathf.Sin(-rotation.y * Mathf.PI / 180) > 5.0f) {
            Destroy(ship);
            rotate.y = 0;
            return;
        }

        int a = position[0] - 65;

        b = Int32.Parse(position.Substring(1)) - 1;

        for (int i = 0; i < length / 10; ++i) {
            if (i == 1 && (rotation.y == 90.0f || rotation.y == 180.0f))
                a = a + 1;
            if (Persistance.perData.placeShips[(int)((a + i * Mathf.Cos(-rotation.y * Mathf.PI / 180)) + 10 * (b + Mathf.Sin(rotation.y * Mathf.PI / 180) * i))] == "S") {
                Destroy(ship);
                rotation.y = 0;
                return;
            }
        }

        a = position[0] - 65;

        for (int i = 0; i < length / 10; ++i) {
            if (i == 1 && (rotation.y == 90.0f || rotation.y == 180.0f))
                a = a + 1;
            Persistance.perData.placeShips[(int)((a + i * Mathf.Cos(-rotation.y * Mathf.PI / 180)) + 10 * (b + Mathf.Sin(rotation.y * Mathf.PI / 180) * i))] = "S";
        }

        rotate.y = 0;
        totalShip--;
        return;


    }



}
