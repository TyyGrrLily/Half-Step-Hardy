using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingGameScript : MonoBehaviour {

    public Movement player;
    public GameObject panel;
    public Text textbox;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(panel.activeSelf)
        {
            if (Input.GetKey(KeyCode.Y))
            {
                textbox.text ="Okay, lets go~";
            }
            else if(Input.GetKey(KeyCode.N))
            {
                textbox.text = "Don't worry, I'll wait";
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collisions)
    {

            panel.SetActive(true);
            player.CanMove(false);

    }
}
