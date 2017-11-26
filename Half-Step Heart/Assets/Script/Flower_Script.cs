using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Flower_Script : MonoBehaviour
{

    public MovementDaytime player;
    public Animator playerAnim;
    public GameObject panel;
    public GameObject darkOut;
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
            if(!playerAnim.GetBool("isSitting"))
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
    private void Dialog()
    {
        if (dialogPlace == 0)
        {
            dialog.text = " 'Remember the last time you were here...?' ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " 'Remember the shell you found, it looked like the sky...' ";
            dialogPlace++;
        }
        else if(dialogPlace == 2)
        {
            dialog.text = " 'That was almost a year ago. Look at how much as change, yet seems the same' ";
            dialogPlace++;
        }
        else if (dialogPlace == 3)
        {
            dialog.text = " 'I still wish for those days, when I wasnt such a hindrance to all my friends...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 4)
        {
            dialog.text = " 'I wish... I was better...' ";
            dialogPlace++;
        }
        else if(dialogPlace == 5)
        {
            dialog.text = " 'I wish...' ";
            dialogPlace++;
        }
        else if (dialogPlace == 6)
        {
            darkOut.SetActive(true);
            dialogPlace++;
        }
        else if (dialogPlace >= 7)
        {
            SceneManager.LoadScene(5);
        }
    }
}