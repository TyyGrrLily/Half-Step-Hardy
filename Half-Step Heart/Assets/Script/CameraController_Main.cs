using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController_Main : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    public float right_barrier;
    public float left_barrier;
    private float y_pos;
    private float x_pos;
    // Use this for initialization
    void Start () {
        y_pos = transform.position.y - player.transform.position.y;
        offset = new Vector3(0F, (y_pos), -10F);
    }
	
	// Update is called once per frame
	void Update () { //Centers camera on player
        if (player.transform.position.x >= left_barrier +1.95F && player.transform.position.x < right_barrier-2.35)
        {
            transform.position = player.transform.position + offset;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y + offset.y, player.transform.position.z + offset.z);
        }
    }
}
