using System.Linq;
using NUnit.Framework;
using UnityEditor;

namespace Tests
{
    public class NoSpriteMipMaps
    {
        [Test]
        public void NoSpriteMipMapsSimplePasses()
        {
            var searchFolders = new[] {"Assets"};
            var assets = AssetDatabase.FindAssets("t:sprite", searchFolders).Select(o =>
                AssetImporter.GetAtPath(AssetDatabase.GUIDToAssetPath(o)) as TextureImporter);
            var eligibleAssets = assets.Where(o => o != null);
            foreach (var textureImporter in eligibleAssets)
            {
                if (textureImporter.mipmapEnabled)
                {
                    Assert.Fail($"Asset with name '{textureImporter.assetPath}' has mipmaps enabled");
                }
            }

            Assert.Pass();
        }
    }
}
