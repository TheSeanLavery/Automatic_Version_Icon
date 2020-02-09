using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderVersionNumber : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Ouput the current Application version into the Console
        Debug.Log("Application Version : " + Application.version);
        version = GetComponent<Text>();
        version.text = "v." + Application.version;
    }

    Text version;
}
