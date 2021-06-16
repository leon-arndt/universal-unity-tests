using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NoUnnamedGameObjects
    {
        [Test]
        public void NoUnnamedGameObjectsSimplePasses()
        {
            var unnamed = GameObject.Find("GameObject");
            Assert.IsNull(unnamed);
        }
    }
}
