using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Animator amin;
    private SpriteRenderer direction;

    void Start()
    {
        amin = GetComponent<Animator>();
        amin.SetBool("isWalking", false);
        direction = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
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
        if (Input.GetKey(KeyCode.Space))
        {
            transform.parent.position += new Vector3(0, .05f, 0);
        }
    }
}
