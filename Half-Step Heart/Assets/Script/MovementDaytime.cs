using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementDaytime : MonoBehaviour
{
    public GameObject collision;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private Animator amin;
    private SpriteRenderer direction;
    public bool _canMove;
    public bool _isHappy;
    void Start()
    {
        amin = GetComponent<Animator>();
        amin.SetBool("isWalking", false);
        //amin.SetBool("isFighting", false);
        direction = GetComponent<SpriteRenderer>();
        _canMove = true;
        amin.SetBool("isHappy", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isHappy)
        {
            amin.SetBool("isHappy", true);
        }
        if (_canMove)
        {
            if (Input.GetKey(KeyCode.RightArrow)) //walking code right
            {
                transform.parent.position += new Vector3(.01f, 0, 0);
                amin.SetBool("isWalking", true);
                direction.flipX = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))//walking code left
            {
                transform.parent.position -= new Vector3(.01f, 0, 0);
                amin.SetBool("isWalking", true);
                direction.flipX = true;
            }
            else
            {
                amin.SetBool("isWalking", false);
            }
            
        }
        else
        {
            amin.SetBool("isWalking", false);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.parent.position += new Vector3(0, .1f, 0);
        }
       //checks for objects interactions
        if (Vector3.Distance(collision.transform.position, transform.position) <= 1 && Input.GetKey(KeyCode.Z))
        {
           
            panel.SetActive(true);
            CanMove(false);
            //collision


        }
    }

    public void CanMove(bool boo) //used outside of this code
    {
        _canMove = boo;
    }

}