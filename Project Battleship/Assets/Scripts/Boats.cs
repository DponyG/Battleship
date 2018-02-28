

//Boats class. That uses inheritance. All Boats have a int value 
//and a isDestroyed
public class Boats {

   private int hp = 0;
   private bool isDestroyed = false;

   virtual public int GetInt() {
        return 0 ;
    }

   virtual public bool GetStatus() {
        if(hp == 0) {
            isDestroyed = true;
        }
        return isDestroyed;
    }

   virtual public void TakeDamage() {
        hp--;
   } 
	
}

//This is the Peral boat which is the longest of the boats
//It has an hp value of 3;
public class StarShip : Boats {

    private int hp = 1;

    bool isDestroyed = false;

    public override int GetInt() {
        return 0;
    }

    public override bool GetStatus() {
        if (hp == 0) {
            isDestroyed = true;
        }
        return isDestroyed;
    }

    public override void TakeDamage() {
        hp--;
    }


}

//This is the Peral boat which is the longest of the boats
//It has an hp value of 3;
public class Voyager : Boats {
    private int hp = 1;

    bool isDestroyed = false;

    public override int GetInt() {
        //return hp;
        return 0;
    }

    public override bool GetStatus() {
        if (hp == 0) {
            isDestroyed = true;
        }
        return isDestroyed;
    }

    public override void TakeDamage() {
        hp--;
    }

}
