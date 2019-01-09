using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {
    [SerializeField]
    GameObject ballprefab;
    [SerializeField]
    float speed = .5f;
    public Vector3 velocity = new Vector3(0, 0, 0);
    private Rigidbody2D rb2d;
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        moveTurning();
        velocity.Normalize();
        transform.position += velocity * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballprefab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<CrazyBoi>().velocity1 = LookAtDirection(transform.eulerAngles.z);
        }

    }
    void movementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75)
            {
                Debug.Log("move left");
                velocity += speed * Vector3.left * Time.deltaTime;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.75)
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
    void moveTurning()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
               
    }
    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
