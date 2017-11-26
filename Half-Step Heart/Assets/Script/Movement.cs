using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject enemy;
    public GameObject collision;
    public GameObject panel;
    public Text dialog;
    public Scene nextScene;
    private Animator amin;
    private SpriteRenderer direction;
    public bool _canMove;
    void Start()
    {
        amin = GetComponent<Animator>();
        amin.SetBool("isWalking", false);
        amin.SetBool("isFighting", false);
        direction = GetComponent<SpriteRenderer>();
        _canMove = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_canMove)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.parent.position += new Vector3(.02f, 0, 0);
                amin.SetBool("isWalking", true);
                direction.flipX = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.parent.position -= new Vector3(.02f, 0, 0);
                amin.SetBool("isWalking", true);
                direction.flipX = true;
            }
            else
            {
                amin.SetBool("isWalking", false);
            }
         /*   if (Input.GetKey(KeyCode.X))
            {
                amin.SetBool("isFighting", true);

            }
            else
            {
                amin.SetBool("isFighting", false);
            }*/

        }
        else
        {
            amin.SetBool("isWalking", false);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.parent.position += new Vector3(0, .1f, 0);
        }
        //transform.parent.rotation = new Vector3(0F, 0F, 0F);
        if(Vector3.Distance(collision.transform.position, transform.position) <= 1 && Input.GetKey(KeyCode.Z))
        {
            Destroy(enemy.gameObject);
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
