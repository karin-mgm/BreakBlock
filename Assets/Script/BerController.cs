using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerController : MonoBehaviour
{
   // private float movableRange = 2f;
   // private float velocityX = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") ;
        transform.position += new Vector3(x, 0, 0)*Time.deltaTime *12 ;
    }

    /*float inputvelocityX = 0;

        if( Input.GetKey(KeyCode.LeftArrow) && -this.movableRange < this.transform.position.x)
        {
            inputvelocityX = -this.velocityX;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < this.movableRange )
        {
            inputvelocityX = this.velocityX;
        }*/
}
