using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BadFinalFlower : MonoBehaviour {
    private Animator amin;
    public GameObject panel;
    public Movement player;
    public Text text;
    public EnemyCode bigEnemy;
    // Use this for initialization
    void Start() {
        amin = GetComponent<Animator>();
        amin.SetBool("isDying", false);
    }

    // Update is called once per frame
    void Update() {
        if (panel.activeSelf)
        {
            amin.SetBool("isDying", true);
            if(Input.GetKey(KeyCode.Z))
            {

            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collisions)
    {

        panel.SetActive(true);
        player.CanMove(false);


    }
}
