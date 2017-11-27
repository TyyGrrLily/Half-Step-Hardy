using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shell_Code : MonoBehaviour
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
            dialog.text = " The Shell! ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " It looks just like how you remembered it! ";
            dialogPlace++;
        } 
        else if(dialogPlace == 2)
        {
            SceneManager.LoadScene(7);
        }
    }
}
