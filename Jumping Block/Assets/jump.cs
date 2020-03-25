using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    private float minHeight = -5;

    private bool hasControl;

    void Update()
    {
        if (hasControl == true)
        {
            if (Input.GetKey(KeyCode.Space))
                transform.position = transform.position+ new Vector3(0,0,0) * Time.deltaTime;
            
                hasControl = false;
        }
        else
        {
            transform.position += Vector3.down * Time.deltaTime;

            if (transform.position.y < minHeight)
                hasControl = true;
        }

    }
}