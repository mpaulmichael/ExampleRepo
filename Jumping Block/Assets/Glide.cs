using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * .05f;
        if (transform.position.x <= -10)
        {
            transform.position = new Vector3(10, -.75f, 0);
        }
    }
}
