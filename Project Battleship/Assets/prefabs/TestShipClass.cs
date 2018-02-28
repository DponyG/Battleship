using NUnit.Framework;
using UnityEngine;


public class TestShipClass {

    [Test]
    public void TestShip() {
        Ship testship = new Ship(2);
        testship.hitCount();
        Assert.AreEqual(testship.GetHp(), 1);
    }
}


