using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

// https://www.gamasutra.com/blogs/RubenTorresBonet/20191112/353795/Unity_Your_Scene_Hierarchy_is_Robbing_you_Performance.php
namespace Tests
{
    public class SceneObjectDepth
    {
        [Test]
        public void SceneObjectDepthSimplePasses()
        {
            var sceneCount = SceneManager.sceneCount;

            const int maxDepth = 7;
            for (var i = 0; i < sceneCount; i++)
            {
                var scene = SceneManager.GetSceneAt(0);
                var rootObjects = scene.GetRootGameObjects();

                foreach (var rootObject in rootObjects)
                {
                    if (Depth(rootObject.transform) > maxDepth)
                    {
                        Assert.Fail($"Nesting of object {rootObject.name} too deep in scene: {scene.name}");
                    }
                }
            }

            Assert.Pass();
        }

        private static uint Depth (Component root, uint depth = 0)
        {
            var children = root.GetComponentsInChildren<Transform>();
            foreach(var component in children)
            {
                if (component.parent == root)
                {
                    return Depth(component, depth + 1);
                }
            }

            return depth;
        }
    }
}
