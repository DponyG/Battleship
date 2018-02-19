
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;


public class TestPersistance {

    [Test]
    public void TestPersistanceSimplePasses() {
        Persistance.perData.index = 3;
        Assert.That(Persistance.perData.index == 0);
        var checkMissed = "O";
        var checkHit = "X";
        Persistance.perData.UpdateString(checkMissed);
        Assert.That(Persistance.perData.selStrings[Persistance.perData.index] == checkMissed);
        Persistance.perData.UpdateString(checkHit);
        Assert.That(Persistance.perData.selStrings[Persistance.perData.index] == checkHit);

    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestPersistanceWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }

}
