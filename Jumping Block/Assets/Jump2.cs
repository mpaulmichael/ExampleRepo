using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    private float maxHeight = 1;
    private float minHeight = 0;

    private bool hasControl=true;
    private void Start()
    {
        transform.position = new Vector3(-7, 0, 0);
    }
    void Update()
    {
        if (hasControl == true)
        {
            if (Input.GetKey(KeyCode.Space))
                transform.position += Vector3.up * 4f/* Time.deltaTime;*/;

            if (transform.position.y >= maxHeight)
                hasControl = false;
        }
        else
        {
            transform.position += Vector3.down * .05f;
            if (transform.position.y <= minHeight)
                
                hasControl = true;
                
        }

            

    }
}