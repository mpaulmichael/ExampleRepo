using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glide2 : MonoBehaviour
{
    public GameObject Cube;
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
        if (transform.position.x >= 0)
        {
            Instantiate (Cube, new Vector3(Random.Range(0f,10.0f),0,0), Quaternion.identity);
        }
        
    }
}
