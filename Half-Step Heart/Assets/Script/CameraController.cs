using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public Text introText;

    private Vector3 offset;
    void Start()
    {
        offset = new Vector3(0F, 1.4F, -10F);
    }
	// Use this for initialization
	void Update () { //follows player, hard coded
        Debug.Log("Camera: " + transform.position);
        Debug.Log("Player: " + player.transform.position);
        if (player.transform.position.x >= 10 && player.transform.position.x < 21.45)
        {
            transform.position = player.transform.position + offset;
        }
        if (player.transform.position.x > 10 && player.transform.position.x < 15) //intro credits
        {
            introText.text = "Designed, Created, & Programed by "
                + "Izabel Hardy";

        }
        else if(player.transform.position.x > 15 && player.transform.position.x < 20)
        {
            introText.color = new Color(0F, 0F, 0F, 0f);
        }
        else if(player.transform.position.x > 20) //Shows Title
        {
            introText.fontSize = 30;
            introText.color = new Color(1F, .321F, .321F, 1F);
            introText.text = "Half-Step Heart";
        }
    }
	
	// Update is called once per frame
	/*void LateUpdate () {
        if( player.transform.position.x > 0 && player.transform.position.x < 11.45)
                transform.position = player.transform.position + offset;
	}*/
}
