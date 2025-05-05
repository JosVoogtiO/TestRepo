using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [Test]
    public void NewTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions
        bool testCondition = true;
        Assert.IsTrue(testCondition);
    }

}
