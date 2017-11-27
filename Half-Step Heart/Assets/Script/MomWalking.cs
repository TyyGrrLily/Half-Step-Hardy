using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MomWalking : MonoBehaviour {
    public MovementDaytime player;
    private Animator amin;
    private int speed = 1;
    private SpriteRenderer x_flip;
    private bool haveTalked;
    public GameObject panel;
    public Text dialog;
    private int dialogPlace;
    // Use this for initialization
    void Start ()
    {
        x_flip = GetComponent<SpriteRenderer>();
        player.CanMove(false);
        haveTalked = false;
        amin = GetComponent<Animator>();
        amin.SetBool("isWalking", true);
        dialogPlace = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, player.transform.position) > 4F && haveTalked == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));
        }
        else if( haveTalked == false) //checks for cimantics
        {
            panel.SetActive(true);
            amin.SetBool("isWalking", false);
            if (dialogPlace == 0)
            {
                dialog.text = " 'Hi honey, please make sure you go out and get some sunlight today.' ";
                dialogPlace++;
            }
            else if (Input.GetKeyUp(KeyCode.Z) && dialogPlace == 1)
            {
                dialog.text = " 'We really worry about you, it'll be good for you health.' ";
                dialogPlace++;
            }
            else if (Input.GetKeyUp(KeyCode.Z) && dialogPlace == 2)
            {

                haveTalked = true;
            }

        }//walks away
        else if(haveTalked == true && Vector3.Distance(transform.position, player.transform.position) < 6F)
        {
            panel.SetActive(false);
            dialog.text = " ";
            x_flip.flipX = true;
            amin.SetBool("isWalking", true);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x + 10, player.transform.position.y), (speed * Time.deltaTime));
        }
        else
        {//destroys object
           
            Destroy(gameObject);
            player.CanMove(true);
        }
    }
}
