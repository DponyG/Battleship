using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Boats class. That uses inheritance. All Boats have a int value 
//and a isDestroyed
public class Boats {

    public int hp = 1; 
    public bool isDestroyed;

   virtual public int GetInt() {
        return 0 ;
    }

    virtual public bool GetStatus() {
        return isDestroyed;
    }
	
}

//This is the Peral boat which is the longest of the boats
//It has an hp value of 3;
public class Peral : Boats {
  //  hp = 3;
    bool isDestroyed = false;

    public override int GetInt() {
        return 0;
    }

    public override bool GetStatus() {
        return isDestroyed;
    }

}

//This is the Peral boat which is the longest of the boats
//It has an hp value of 3;
public class Fang : Boats {
  //  hp = 2;
    bool isDestroyed = false;

    public override int GetInt() {
        //return hp;
        return 0;
    }

    public override bool GetStatus() {
        return isDestroyed;
    }

}
