using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//Uses happy movement is same a daytime movement but with different animation
public class HappyMovement : MonoBehaviour
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
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.parent.position += new Vector3(.01f, 0, 0);
                amin.SetBool("isWalking", true);
                direction.flipX = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
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
        
        if (Vector3.Distance(collision.transform.position, transform.position) <= 1 && Input.GetKey(KeyCode.Z))
        {
            panel.SetActive(true);
            CanMove(false);
            //collision
        }
    }
    private void Wait(string scene)
    {
        new WaitForSeconds(5);
        SceneManager.LoadScene(scene);
    }
    public void CanMove(bool boo)
    {
        _canMove = boo;
    }

}