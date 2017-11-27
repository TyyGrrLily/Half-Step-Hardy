using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Heart_Good_Ending : MonoBehaviour {

    public GameObject panel;
    public Text dialog;
    private int dialogPlace;
    // Use this for initialization
    void Start () {
        dialogPlace = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (panel.activeSelf == false && Input.GetKeyUp(KeyCode.Z))
        {
            panel.SetActive(true);
        }else if(panel.activeSelf && Input.GetKeyUp(KeyCode.Z))
        {
            Dialog();
        }
    }
    //Dialog, avoids accidentally skipping parts
    private void Dialog()
    {
        if (dialogPlace == 0)
        {
            dialog.text = " Thank you for playing! ";
            dialogPlace++;
        }
        else if (dialogPlace == 1)
        {
            dialog.text = " A tomorrow to look forward for! ";
            dialogPlace++;
        }
        else if (dialogPlace == 2)
        {
            Application.Quit();
        }
    }
}
