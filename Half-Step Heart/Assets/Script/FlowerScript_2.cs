using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlowerScript_2 : MonoBehaviour
{

    public MovementDaytime player;
    public Animator playerAnim;
    public GameObject panel;
    public GameObject darkOut;
    public GameObject sunset;
    public GameObject sunsetGround;
    public Text dialog;
    public Scene nextScene;
    private int dialogPlace;
    // Use this for initialization
    void Start()
    {
        playerAnim.SetBool("isSitting", false);
        dialogPlace = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf && Input.GetKeyUp(KeyCode.Z))
        {
            if (!playerAnim.GetBool("isSitting"))
            {
                playerAnim.SetBool("isSitting", true);
            }
            Dialog();

        }

    }
    private void OnCollisionEnter2D(Collision2D collisions)
    {

        panel.SetActive(true);
        player.CanMove(false);

    }
    //Dialog, avoids accidentally skipping parts
    private void Dialog()
    {
        if (dialogPlace == 0)
        {
            dialog.text = " 'It okay...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " 'Things will be okay...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 2)
        {
            dialog.text = " 'Just got to give it time...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 3)
        {
            dialog.text = " 'I wish things were easier...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 4)
        {
            dialog.text = " 'I wish... ' ";
            dialogPlace++;
        }
        else if (dialogPlace == 5)
        {
            dialog.text = " 'But I am all out of wishing stars.' ";
            dialogPlace++;
        }
        else if (dialogPlace == 6)
        {
            dialog.text = "";
            darkOut.SetActive(true);
            sunset.SetActive(false);
            sunsetGround.SetActive(false);
            dialogPlace++;
        }
        else if (dialogPlace == 7)
        {
            darkOut.SetActive(false);
            dialogPlace++;
        }
        else if (dialogPlace == 8)
        {
            dialog.text = " 'What a wonderful world...' ";
            dialogPlace++;
        }
        
        else if(dialogPlace == 9)
        {
            darkOut.SetActive(true);
            dialogPlace++;
        }
        else if(dialogPlace >= 10)
        {
            SceneManager.LoadScene(13);
        }
    }
}