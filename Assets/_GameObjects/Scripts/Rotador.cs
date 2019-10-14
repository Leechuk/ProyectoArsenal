using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    

    float x;
    float y;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        print(transform.rotation.eulerAngles.x);
        /*if(transform.rotation.eulerAngles.x>10 || transform.rotation.eulerAngles.x < 350)
        {
            transform.Rotate(0, x, 0, Space.World);
            transform.Rotate(y * -1, 0, 0);
        }*/
        transform.Rotate(0, x, 0, Space.World);
        transform.Rotate(y * -1, 0, 0);



    }

   

}
