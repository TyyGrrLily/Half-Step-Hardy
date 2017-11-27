using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalFlower : MonoBehaviour
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
        if (dialogPlace == 0)
        {
            dialog.text = " Seeing this flower inspires you! ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " A tomorrow to look forward for! ";
            dialogPlace++;
        }
        else if (dialogPlace == 2)
        {
            SceneManager.LoadScene(19);
        }
    }
}
