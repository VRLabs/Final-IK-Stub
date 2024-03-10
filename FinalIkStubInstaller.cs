#if UNITY_EDITOR
using System;
using System.IO;
using System.Linq;
using UnityEditor;

[InitializeOnLoad]
public class FinalIKStubInstaller
{
    static FinalIKStubInstaller()
    {
        bool fikStubPresent = AppDomain.CurrentDomain.GetAssemblies()
            .Any(x => x.GetTypes().Any(y => y.FullName == "RootMotion.FinalIK.Grounder"));
        bool anythingInLocation = Directory.Exists("Assets/Plugins/RootMotion");
        if (fikStubPresent && !anythingInLocation)
        {
            
            EditorUtility.DisplayDialog("Bad Final IK Install", "Final IK Found in wrong folder. Please move your Final IK/Final IK Stub over to Assets/Plugins/RootMotion", "Ok");
        } 

        if (!fikStubPresent && !anythingInLocation)
        {
            string file = AssetDatabase.FindAssets("FinalIkStubInstaller", new[] { "Packages", "Assets" }).Select(AssetDatabase.GUIDToAssetPath).FirstOrDefault();
            
            if (file == null)
            {
                EditorUtility.DisplayDialog("Bad Final IK Install", "Final IK Stub not found. Please install Final IK Stub from the package manager", "Ok");
                return;
            }
            
            string[] files = Directory.GetFiles(Path.GetDirectoryName(file) + "/RootMotion", "*.*", SearchOption.AllDirectories);
            CopyFiles(files, "Assets/Plugins/");
        }
    }
    

    private static void CopyFiles(string[] files, string finalPath)
    {
        foreach (var file in files)
        {
            if (file.EndsWith(".cs.no"))
            {
                string partialPath = file.Substring(file.IndexOf("RootMotion", StringComparison.Ordinal));
                string directory = Path.GetDirectoryName(partialPath);
                if (!string.IsNullOrEmpty(directory))
                {
                    Directory.CreateDirectory(finalPath + directory);
                }
                
                File.Copy(file, finalPath + partialPath.Replace(".cs.no", ".cs"));
                File.Copy(file.Replace(".cs.no", ".cs.meta.no"), finalPath + partialPath.Replace(".cs.no",".cs.meta"));
            }
        }
    }
}

#endif