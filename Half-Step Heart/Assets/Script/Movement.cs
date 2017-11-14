using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.parent.position += new Vector3(.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.parent.position -= new Vector3(.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.parent.position += new Vector3(0, .1f, 0);
        }
    }
}
