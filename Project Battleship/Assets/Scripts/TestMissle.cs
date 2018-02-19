using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

//TestMissle instantiates the missile gameObject and
//checks to see if its destroyed in 6 seconds.
public class TestMissle {
    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestMissleWithEnumeratorPasses() {
        SetupScene();
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return new WaitForSeconds(6);
        Assert.That("Missle.clone" == null);
    }

    void SetupScene() {

        MonoBehaviour.Instantiate(Resources.Load<GameObject>("Scenery"));
        MonoBehaviour.Instantiate(Resources.Load<GameObject>("Missle"));


    }
}
