using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private float deadLine = -5;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(300, 300));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadLine)
        {
            Destroy(gameObject);
        }
    }
}
