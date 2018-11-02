using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    GameObject ballprefab;
    [SerializeField]
    float speed = .5f;
    public Vector3 velocity = new Vector3(0, 0, 0);
    private Rigidbody2D rb2d;
    private GameObject newShot;


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

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (!newShot)
            {
                newShot = Instantiate(ballprefab);
                newShot.transform.position = transform.position;
                Vector3 position = newShot.transform.position;
                position[2] = 6;
                newShot.transform.position = position;

                
            }
            
            
            

        }

    }
    void movementWASD()
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
            if (transform.position.y < -.46)
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
    private void OnTriggerEnter2D(Collider2D playerC)
    {
        if (playerC.gameObject.CompareTag("Millipede"))
        {
            Destroy(gameObject);
        }

    }

}
