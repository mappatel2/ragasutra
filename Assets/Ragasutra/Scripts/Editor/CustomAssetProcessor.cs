using UnityEngine;
using UnityEditor;
using System.IO;

using Ragasutra.Scripts.Data;

namespace Ragasutra.Scripts.Editor
{
    public static class CustomAssetProcessor
    {
        [MenuItem("Tools/Move Assets")]
        public static void MoveAssets()
        {
            using(new AssetDatabase.AssetEditingScope())
            {
                string[] srcDirectoryPath = { "Assets/Data" };
                string destDirectoryPath = "Assets/Data_1";

                if (!AssetDatabase.IsValidFolder(srcDirectoryPath[0]) || !AssetDatabase.IsValidFolder(destDirectoryPath))
                {
                    Debug.LogWarning("Invalid Folders");
                    return;
                }

                string[] assetGuids = AssetDatabase.FindAssets("t:RagaData", srcDirectoryPath);
                int totalAssetCount = assetGuids.Length;
                for (int i = 0; i < totalAssetCount; i++)
                {
                    EditorUtility.DisplayCancelableProgressBar("Asset Moving", $"Moving Asset Number : {i + 1} / {totalAssetCount}",
                        (float)i / totalAssetCount);

                    string srcAssetPath = AssetDatabase.GUIDToAssetPath(assetGuids[i]);
                    string assetName = Path.GetFileName(srcAssetPath);
                    string destAssetPath = $"{destDirectoryPath}/{assetName}";
                    AssetDatabase.MoveAsset(srcAssetPath, destAssetPath);
                }

                EditorUtility.ClearProgressBar();
            }
        }

        [MenuItem("Tools/Create Assets")]
        public static void CreateAssets()
        {
            int totalAssetCount = 10000;
            string assetDirectoryPath = "Assets/Data";
            using (new AssetDatabase.AssetEditingScope())
            {
                for (int i = 0; i < totalAssetCount; i++)
                {
                    EditorUtility.DisplayCancelableProgressBar("Asset Creation", $"Creating Asset Number : {i + 1} / {totalAssetCount}",
                        (float)i / totalAssetCount);
                    var data = ScriptableObject.CreateInstance<RagaData>();
                    AssetDatabase.CreateAsset(data, $"{assetDirectoryPath}/Data_{i+1}.asset");
                }
                
                EditorUtility.ClearProgressBar();
            }
        }
    }
}
