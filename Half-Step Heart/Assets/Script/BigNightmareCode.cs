using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BigNightmareCode : MonoBehaviour
{
    public GameObject player;
    public GameObject collision;
    public GameObject panel;
    private SpriteRenderer x_flip;
    public LayerMask layer;
    public Scene currentScene;
    private float speed = .8F;
    public float speedchanger;
    private float minDist = .2F;
    private int num;

    void Start()
    {
        x_flip = GetComponent<SpriteRenderer>();
        num = 0;
    }
    void Update()
    {



        if (Vector3.Distance(transform.position, player.transform.position) > minDist)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));
            if( transform.position.x > 5 && num ==0)
            {
                speed += speedchanger;
                num++;
            }
            else if (transform.position.x > 10 && num == 1)
            {
                speed += speedchanger;
                num++;
            }
           else if (transform.position.x > 15 && num == 2)
            {
                speed += speedchanger;
                num++;
            }
            else if (transform.position.x > 20 && num == 3)
            {
                speed += speedchanger;
                num++;
            }
            else if (transform.position.x > 25 && num == 4)
            {
                speed += speedchanger;
                num++;
            }


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
