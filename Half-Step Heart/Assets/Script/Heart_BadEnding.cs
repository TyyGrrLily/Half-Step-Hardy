using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Not used, not enough time to implement
public class Heart_BadEnding : MonoBehaviour
{
    private Animator amin;
    public GameObject panel;
    public Text text;
    // Use this for initialization
    void Start()
    {
        amin = GetComponent<Animator>();
        amin.SetBool("isDepressed", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!amin.GetBool("isDepressed") && Input.GetKeyUp(KeyCode.Z))
        {
            amin.SetBool("isDepressed", true);
        }
        else if(Input.GetKeyUp(KeyCode.Z))
            Ending();
        else if(Input.GetKeyUp(KeyCode.Z))
            Application.Quit();
    }
    private void Ending()
    {
        panel.SetActive(true);
        text.text = "Bad Ending";
    }
}