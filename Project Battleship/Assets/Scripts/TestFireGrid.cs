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
        CreateKVP test = new CreateKVP();
        CreateKVP test2 = new CreateKVP();
        test.CreateFriendlyKVP(testString);
        test2.CreateFriendlyKVP(testString2);
        Dictionary<string, Vector3> testKVP = test.GetKVPF();
        Dictionary<string, Vector3> testKVP2 = test2.GetKVPF();
        var value = testKVP["A1"];
        var value1 = testKVP2["B1"];
        Assert.That(value == new Vector3(5.0f, 0.0f, -5.0f));
        Assert.That(value1 == new Vector3(15.0f, 0.0f, -5.0f));


    }
}
  
