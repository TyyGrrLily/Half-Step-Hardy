﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalBigNIghtmare : MonoBehaviour
{

    public GameObject player;
    public GameObject collision;
    public GameObject panel;
    private SpriteRenderer x_flip;
    public LayerMask layer;
    public Scene currentScene;
    private float speed = .6F;
    public float speedchanger = .4F;
    private float minDist = 1F;
    private int num;

    void Start()
    {
        x_flip = GetComponent<SpriteRenderer>();
        num = 0;
    }
    void Update()
    {


        //Chases player with out speeding up
        if (Vector3.Distance(transform.position, player.transform.position) > minDist)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));
            if (transform.position.x > 5 && num == 0)


            if (transform.position.x - player.transform.position.x > 0)
            {
                x_flip.flipX = true;
            }
            else
            {
                x_flip.flipX = false;
            }
        }
        else
        {
            //https://answers.unity.com/questions/64395/reload-current-level-when-i-die.html
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);

        }
        if (panel.activeSelf)
        {
            Destroy(gameObject);

        }

    }
}
