using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SingleMainCamera
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SingleMainCameraSimplePasses()
        {
            var mainCameras = GameObject.FindGameObjectsWithTag("MainCamera");
            Assert.AreEqual(1, mainCameras.Length);
        }
    }
}
