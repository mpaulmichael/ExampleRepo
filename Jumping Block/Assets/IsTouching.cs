using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouching : MonoBehaviour
{
    public GameObject Slide;
    public GameObject Slide1;
    Transform myTransform;
    Transform myTransform1;

    // Start is called before the first frame update
    void Start()
    {
       // myTransform = Slide.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myTransform = Slide.GetComponent<Transform>();
        myTransform1 = Slide1.GetComponent<Transform>();
        if ((transform.position.y<0.75f && transform.position.y>-0.5f) && ((myTransform.position.x<-6.4f && myTransform.position.x>=-7.3f) || (myTransform1.position.x<-6.4f && myTransform1.position.x>=-7.3f)))
     {
        transform.position = new Vector3(10, -.75f, 0);
     }
    }
}
