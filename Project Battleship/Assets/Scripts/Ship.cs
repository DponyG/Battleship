

public class Ship  {

    private int hp;

    public Ship(int _hp) {
        hp = _hp;
    }

    public void hitCount() {
        hp--;
    }

    public int GetHp() {
        return hp;
    }
}

