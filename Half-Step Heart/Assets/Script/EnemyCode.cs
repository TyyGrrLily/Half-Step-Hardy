using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCode : MonoBehaviour {
    public GameObject player;
    private Vector3 temp;
    private SpriteRenderer x_flip;
    public LayerMask layer;
    private int _moveSpeed = 1;
    private int _maxDist = 3;
    private float _minDist = .1F;
    private bool _characterFound = false;

    void Start()
    {
        x_flip = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
       

        if (Vector3.Distance(transform.position, player.transform.position) >= _minDist)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, (_moveSpeed * Time.deltaTime));
            if( transform.position.x-player.transform.position.x > 0)
            {
                x_flip.flipX = true;
            }
            else
            {
                x_flip.flipX = false;
            }
        }
        if(Physics2D.OverlapCircle(player.transform.position, .1F, layer))
        {
           // SceneManager.LoadScene("NightRealm");
        }
    }
}
