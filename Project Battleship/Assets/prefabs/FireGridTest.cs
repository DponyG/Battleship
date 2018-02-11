using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;


public class FireGridTest {


    [Test]
    public void FireGridTestSimplePasses() {
        string[] arr = new string[] { "A1", "B1" };
        CreateKVP test = new CreateKVP(arr);
        Dictionary<string, Vector3> testKVP = test.GetKVP();
        var value = testKVP["A1"];
        var value1 = testKVP["B1"];
        Assert.That(value == new Vector3(0.0f, 0.0f,0.0f));
        Assert.That(value1 == new Vector3(0.0f, 0.0f, 10.0f));

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
