using NUnit.Framework;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class SceneRootCount
    {
        [Test]
        public void SceneRootCountSimplePasses()
        {
            var sceneCount = SceneManager.sceneCount;

            for (int i = 0; i < sceneCount; i++)
            {
                var scene = SceneManager.GetSceneAt(0);
                var rootCount = scene.rootCount;
                const int maxObjects = 25;
                if (rootCount > maxObjects)
                {
                    Assert.Fail("Too many root objects in scene: " + scene.name);
                }

            }
            Assert.Pass();
        }
    }
}
