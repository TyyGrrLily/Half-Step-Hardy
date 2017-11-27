using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorCode : MonoBehaviour {

    public GameObject player;
        public GameObject panel;
    public Text dialog;
    private int nextScene;
    private int dialogPlace;
    public int dayNum;
    
    // Use this for initialization
    void Start ()
    {
        dialogPlace = 0;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (panel.activeSelf && Input.GetKeyUp(KeyCode.Z) && Vector3.Distance(player.transform.position, transform.position) <= 1)
        {
            Dialog();
        }

    }
    private void OnCollisionEnter2D(Collision2D collisions)
    {
 
            panel.SetActive(true);
           // player.CanMove(false);
            Dialog();

    }
    //Dialog, avoids accidentally skipping parts for leaving the house
    private void Dialog()
    { 
        

        if (dialogPlace == 0)
        {
            if (dayNum == 1)
            {
                dialog.text = "Lets head to the beach";
                nextScene = 4;
                dialogPlace++;
            }
            else if (dayNum == 2)
            {
                dialog.text = "Lets go to school";
                nextScene = 8;
                dialogPlace++;
            }
            else if (dayNum == 3)
            {
                dialog.text = "Lets go to the beach again";
                nextScene = 12;
                dialogPlace++;
            }
            else if (dayNum == 4)
            {
                dialog.text = "Time for school";
                nextScene = 16;
                dialogPlace++;
            }
            else if (dayNum == 5)
            {
                dialog.text = "Lets go to the park";
                nextScene = 20;
                dialogPlace++;
            }



        }
        else if (dialogPlace ==1)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
