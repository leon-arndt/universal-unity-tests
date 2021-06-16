using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SemanticProjectVersion
    {
        [Test]
        public void SemanticProjectVersionSimplePasses()
        {
            Assert.IsTrue(IsSemantic(Application.version));
        }

        private static bool IsSemantic(string check)
        {
            const string pattern = @"^([0-9]+)\.([0-9]+)\.([0-9]+)(?:-([0-9A-Za-z-]+(?:\.[0-9A-Za-z-]+)*))?(?:\+[0-9A-Za-z-]+)?$";
            return Regex.IsMatch(check, pattern);
        }
    }
}
