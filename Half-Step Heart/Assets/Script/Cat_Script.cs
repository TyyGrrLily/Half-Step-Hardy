using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Cat_Script : MonoBehaviour {

    public Movement player;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private int dialogPlace;
    // Use this for initialization
    void Start () {
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
            dialog.text = "Heart, you need to wake up!";
            dialogPlace++;
        }
        else if (dialogPlace == 1 && Input.GetKeyUp(KeyCode.Z))
        {
            SceneManager.LoadScene(3);
        }
    }
}
