using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class FinalIKStubInstaller
{
	static FinalIKStubInstaller()
	{
		bool fikStubPresent = AppDomain.CurrentDomain.GetAssemblies()
			.Any(x => x.GetTypes().Any(x => x.FullName == "RootMotion.FinalIK.Grounder"));
		bool anythingInLocation = Directory.Exists( "Assets/Plugins/RootMotion");
		if (fikStubPresent && !anythingInLocation)
		{
			EditorUtility.DisplayDialog("Bad Final IK Install", "Final IK Found in wrong folder. Please move your Final IK/Final IK Stub over to Assets/Plugins/RootMotion", "Ok");
		}

		if (!fikStubPresent && !anythingInLocation)
		{
			Debug.Log("Importing Final IK 1.9 Stub");
			string[] fikStubLocations = AssetDatabase.FindAssets("Final_IK_v1.9_Stub");
			if (fikStubLocations.Length == 0)
			{
				throw new Exception("Final IK Stub Package not found");
			}
			AssetDatabase.ImportPackage(AssetDatabase.GUIDToAssetPath(fikStubLocations[0]), false);
		}
	}
}
