using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CameraCount
    {
        [Test]
        public void CameraCountSimplePasses()
        {
            var cameraCount = Object.FindObjectsOfType<Camera>().Length;
            const int maxCount = 5;
            Assert.LessOrEqual(cameraCount, maxCount);
        }
    }
}