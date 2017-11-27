using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SchoolCode : MonoBehaviour {
    public GameObject darkout;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { //Opening darkness
        if (Input.GetKeyUp(KeyCode.Z) && text.text != "")
        {
            darkout.SetActive(false);
            text.text = "";
        }
        
	}
}
