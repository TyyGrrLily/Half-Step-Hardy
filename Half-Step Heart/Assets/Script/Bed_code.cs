using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bed_code : MonoBehaviour {
    public int dayNum;
    private int nextScene;
    public bool daytime;
    public GameObject panel;
    public Text text;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
       
    }

    // Update is called once per frame
    void Update() {
        if (panel.activeSelf && Input.GetKeyUp(KeyCode.Z) && Vector3.Distance(player.transform.position, transform.position) <= 1)
        {
            Dialog();
        }
    }
    private void OnCollisionEnter2D(Collision2D collisions)
    {
        panel.SetActive(true);

    }
    private void Dialog()
    {
        if (dayNum == 1)
        {
            nextScene = 6;
        }
        else if (dayNum == 2)
        {
            nextScene = 10;
        }
        else if (dayNum == 3)
        {
            nextScene = 14;
        }
        else if (dayNum == 4)
        {
                nextScene = 18;
        }
        SceneManager.LoadScene(nextScene);
    }
        
}
