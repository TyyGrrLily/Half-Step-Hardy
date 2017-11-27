using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FriendCode : MonoBehaviour
{
    public MovementDaytime player;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private int dialogPlace;
    public GameObject darkOut;
    public int dayNum;
    // Use this for initialization
    void Start()
    {
        dialogPlace = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf && Input.GetKeyUp(KeyCode.Z))
        {
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
        if (dayNum == 1)
        {
            if (dialogPlace == 0)
            {
                dialog.text = " Friend: 'Hey Heart, how have you been?' ";
                dialogPlace++;
            }
            else if (dialogPlace == 1)
            {
                dialog.text = " Heart: 'Meh, it could be worse...' ";
                dialogPlace++;
            }
            else if (dialogPlace == 2)
            {
                dialog.text = " Friend: 'Want to go out this evening? We are going out dancing!' ";
                dialogPlace++;
            }
            else if (dialogPlace == 3)
            {
                dialog.text = " Heart: 'Sorry, I can't right now...' ";
                dialogPlace++;
            }
            else if (dialogPlace == 4)
            {
                dialog.text = " Friend: 'Are you sure? It could be fun just to hang out?' ";
                dialogPlace++;
            }
            else if (dialogPlace == 5)
            {
                dialog.text = " Heart: 'Sorry, I just don't have the energy. Thank you though.' ";
                dialogPlace++;
            }
            else if (dialogPlace == 6)
            {
                dialog.text = " ";
                darkOut.SetActive(true);
                dialogPlace++;
            }
            else if (dialogPlace >= 7)
            {
                SceneManager.LoadScene(9);
            }
        }
        else if(dayNum ==2)
        {

            if (dialogPlace == 0)
            {
                dialog.text = " Friend: 'Hey Heart, wanna go to the park tomorrow?' ";
                dialogPlace++;
            }
            else if (dialogPlace == 1)
            {
                dialog.text = " Heart: 'Um, maybe.' ";
                dialogPlace++;
            }
            else if (dialogPlace == 2)
            {
                dialog.text = " Friend: 'The flowers look lovely this time of year, you'll love it!' ";
                dialogPlace++;
            }
            else if (dialogPlace == 3)
            {
                dialog.text = " Heart: 'Um, okay. Lets do it.' ";
                dialogPlace++;
            }

            else if (dialogPlace == 4)
            {
                dialog.text = " ";
                darkOut.SetActive(true);
                dialogPlace++;
            }
            else if (dialogPlace >= 5)
            {
                SceneManager.LoadScene(17);
            }
        }
       
    }
}
