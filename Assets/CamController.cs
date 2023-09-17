using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    float moveSpeed;
    void Start()
    {
        moveSpeed = 1.0f;
    }
 
    void Update()
    {
        Vector3 vec = Vector3.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            vec += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vec += Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vec += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vec += Vector3.down;
        }
        vec = vec.normalized * moveSpeed * Time.deltaTime;
        transform.Translate(vec);
    }
}
