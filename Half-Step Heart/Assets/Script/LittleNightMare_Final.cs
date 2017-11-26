using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LittleNightMare_Final : MonoBehaviour
{
    public GameObject player;
    public GameObject collision;
    public GameObject panel;
    private Vector3 temp;
    private SpriteRenderer x_flip;
    public LayerMask layer;
    public Scene currentScene;
    private int speed = 1;
    private float minDist = .1F;

    void Start()
    {
        x_flip = GetComponent<SpriteRenderer>();
    }
    void Update()
    {



        if (Vector3.Distance(transform.position, player.transform.position) > minDist)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));
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
            
        }
        if (panel.activeSelf)
        {
            Destroy(gameObject);

        }
        /*  void OnTriggerEnter(Collider other)
          {
              if (other.gameObject.tag == "Player")
              {
                  SceneManager.LoadScene("NightRealm");
              }
          }*/
    }
}
