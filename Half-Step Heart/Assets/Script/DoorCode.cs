using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorCode : MonoBehaviour {

    public MovementDaytime player;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private bool doorBool;
    // Use this for initialization
    void Start ()
    {
        doorBool = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (panel.activeSelf && Input.GetKeyUp(KeyCode.Z))
        {
            dialog.text = "Where do you want to go? Press for 1 School, 2 for Beach or X for cancel";
        }

    }
    private void OnCollisionEnter2D(Collision2D collisions)
    {
        panel.SetActive(true);
        player.CanMove(false);
        doorBool = true;
    }
    private void Dialog()
    {
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            dialog.text = " To School I go ";
        }
        else if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            dialog.text = " The beach sounds real nice ";
        }
        else if(Input.GetKeyUp(KeyCode.X))
        {
            panel.SetActive(false);
        }
    }
}
