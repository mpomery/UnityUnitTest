using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class UnitTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void UnitTestSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.IsTrue(false);
        }
    }
}
