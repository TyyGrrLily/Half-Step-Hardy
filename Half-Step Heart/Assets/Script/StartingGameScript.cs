using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingGameScript : MonoBehaviour
{

    public Movement player;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private int dialogPlace;
    // Use this for initialization
    void Start()
    {
        dialogPlace = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf)
        {
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
            dialog.text =  " Hello Heart. Want to see your nightmares? (z for yes, x for no)";
            dialogPlace++;
        }
        else if (dialogPlace == 1 && Input.GetKeyUp(KeyCode.Z))
        {
            dialog.text = " Okay, lets go~";
            dialogPlace++;
        }
        else if (dialogPlace == 1 && Input.GetKeyUp(KeyCode.X))
        {
            dialog.text = "You think you have a choice?";
        }
        else if (dialogPlace == 2 && (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.Z)))
        {
            SceneManager.LoadScene(2);
        }
    }
}