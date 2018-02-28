using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persistance : MonoBehaviour {

    //TODO make these private?
    public bool cpuFire;
    public bool urFire;
    public static Persistance perData;
  
    public int index = 0; // for TESTING ONLY

    //TODO make these private?
    public Ship urFreighter = new Ship(5);
    public Ship urCarrier = new Ship(4);
    public Ship urStarship = new Ship(3);
    public Ship urVoyager = new Ship(2);
    public Ship cpuFreighter = new Ship(5);
    public Ship cpuCarrier = new Ship(4);
    public Ship cpuStarship = new Ship(3);
    public Ship cpuVoyager = new Ship(2);


    private Vector3 missileCoord;
    private bool timeToMove;
    private int shipIndex;
    private int fireIndex;
    private int shipLost;
    private int shipDestroyed;

    public enum States { User, Computer };
  
    public static States state;

    public string[] selStrings = new string[] { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1", "I1", "J1", "A2", "B2", "C2", "D2", "E2",
                                                "F2","G2", "H2", "I2", "J2", "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3", "I3", "J3",
                                                "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "I4", "J4", "A5", "B5", "C5", "D5", "E5", "F5",
                                                 "G5", "H5", "I5", "J5", "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6", "I6", "J6", "A7", "B7",
                                                 "C7", "D7", "E7", "F7", "G7", "H7", "I7", "J7", "A8", "B8", "C8", "D8", "E8","F8", "G8", "H8",
                                                 "I8", "J8", "A9", "B9", "C9", "D9", "E9", "F9", "G9", "H9", "I9", "J9", "A10", "B10", "C10", "D10",
                                                 "E10", "F10", "G10", "H10", "I10", "J10"};

    public string[] placeShips = new string[] { "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1", "I1", "J1", "A2", "B2", "C2", "D2", "E2",
                                                "F2","G2", "H2", "I2", "J2", "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3", "I3", "J3",
                                                "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4", "I4", "J4", "A5", "B5", "C5", "D5", "E5", "F5",
                                                 "G5", "H5", "I5", "J5", "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6", "I6", "J6", "A7", "B7",
                                                 "C7", "D7", "E7", "F7", "G7", "H7", "I7", "J7", "A8", "B8", "C8", "D8", "E8","F8", "G8", "H8",
                                                 "I8", "J8", "A9", "B9", "C9", "D9", "E9", "F9", "G9", "H9", "I9", "J9", "A10", "B10", "C10", "D10",
                                                 "E10", "F10", "G10", "H10", "I10", "J10"};





    //Allows us to keep this GameObject upon switching scenes.
    //All other GameObjects of the same type will be destroyed.
    private void Awake() {
        if (perData == null) {
            DontDestroyOnLoad(gameObject);
            perData = this;
        } else if (perData != this) {
            Destroy(gameObject);
        }
    }
    //Puts the Fire Coordinates in a persistance state 
    //So it may be used by the missile object
    public void UpdateString(string status) {
        selStrings[index] = status;
    }

    public void SetShipIndex(int index) {
        shipIndex = index;
    }

    public int GetShipIndex() {
        return shipIndex;
    }

    public void SetTimeToMove(bool _timeToMove) {
        timeToMove = _timeToMove;
    }

    public bool GetTimeToMove(bool _timeToMove) {
        return timeToMove;
    }

    public void SetMissileCoord(Vector3 _missileCoord) {
        missileCoord = _missileCoord;
    }

    public Vector3 GetMissileCoord() {
        return missileCoord;
    }

    public static void ChangeState(States stateTo) {
        if (state == stateTo)
            return;
        state = stateTo;
    }

    public static bool IsState(States stateTo) {
        if (state == stateTo)
            return true;
        return false;
    }

    public static bool IsUser {
        get {
            return IsState(States.User);
        }
        
    }

    public static bool IsComputer {
        get {
            return IsState(States.Computer);
        }
    }

    public void SetFireIndex(int _fireIndex) {
        fireIndex = _fireIndex;
    }

    public int GetFireIndex() {
        return fireIndex;
    }

   public void IncrementShipLost() {
        shipLost++;
    }

    public int GetShipLost() {
        return shipLost;
    }

    public int GetShipDestroyed() {
        return shipDestroyed;
    }

    public void IncrementShipDestroyed() {
        shipDestroyed++;
    }

    void Start() {
       
    }

    void Update() {
        if(Input.GetKey("l")) {
            IncrementShipDestroyed();
        }
        if(GetShipDestroyed() >= 5) {
            SceneManager.LoadScene("Win");
        }
    }

}
