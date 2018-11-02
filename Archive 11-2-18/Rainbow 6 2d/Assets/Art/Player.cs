using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float speed = .5f;
    private Vector3 velocity = new Vector3(0, 0, 0);
    private Rigidbody2D rb2d;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        movementWASD();

        velocity.Normalize();
        transform.position += velocity * speed * Time.deltaTime;

    }
    private void movementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.775)
            {

                Debug.Log("move left");
                velocity += speed * Vector3.left * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.775)
            {
                Debug.Log("move right");
                velocity += speed * Vector3.right * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 1)
            {
                Debug.Log("move up");
                velocity += speed * Vector3.up * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                Debug.Log("move down");
                velocity += speed * Vector3.down * Time.deltaTime;
            }

        }

    }
}
