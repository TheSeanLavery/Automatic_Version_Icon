using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class AutoVersion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    [PostProcessBuild]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        float versionFloat;

        if (float.TryParse(PlayerSettings.bundleVersion, out versionFloat))
        {
            versionFloat += 0.01f;
            PlayerSettings.bundleVersion = versionFloat.ToString();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
