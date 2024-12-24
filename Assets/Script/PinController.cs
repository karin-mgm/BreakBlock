using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PinController : MonoBehaviour
{
    public AudioSource sound1;
    public AudioSource sound2;

    private float deadLine = -5;
    private int buffer = 0;

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
            if (buffer == 0)
            {
                sound1.Play();
                

            }
            buffer++;  //音がなってからデストロイ
            if (buffer > 200)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Destroy(gameObject);
            }
        }

        if (GameObject.FindGameObjectsWithTag("blockTag").Length == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound2.Play();
    }

    
}
