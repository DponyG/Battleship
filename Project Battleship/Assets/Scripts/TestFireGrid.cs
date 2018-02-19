using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class TestFireGrid {

    [Test]
    public void FireGridTestSimplePasses() {
        string testString = "A1";
        string testString2 = "B1";
        CreateKVP test = new CreateKVP(testString);
        CreateKVP test2 = new CreateKVP(testString2);
        Dictionary<string, Vector3> testKVP = test.GetKVP();
        Dictionary<string, Vector3> testKVP2 = test2.GetKVP();
        var value = testKVP["A1"];
        var value1 = testKVP2["B1"];
        Assert.That(value == new Vector3(5.0f, 0.0f, -5.0f));
        Assert.That(value1 == new Vector3(15.0f, 0.0f, -5.0f));
        

    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator FireGridTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }

}
