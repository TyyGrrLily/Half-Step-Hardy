using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mirror_Code : MonoBehaviour
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
            dialog.text = " You look into the mirror... ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " Its looks like you but not at the same time ";
            dialogPlace++;
        }
        else if (dialogPlace == 2)
        {
            dialog.text = " Strange and different, not bad, nor good. ";
            dialogPlace++;
        }
        else if (dialogPlace == 3)
        {
            dialog.text = " There's something reasuring about that. ";
            dialogPlace++;
        }
        else if (dialogPlace == 4)
        {
            SceneManager.LoadScene(11);
        }
    }
}
