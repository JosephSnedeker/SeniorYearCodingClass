using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Vector3 velocity = new Vector3(0, 0, 0);
    Vector3 crouch = new Vector3(0, 0, 0);
    [SerializeField]
    float speed = 4;
    [SerializeField]
    float jump = 4;
    Rigidbody2D rb2d;
    Transform trans;
    public List<Vector3> teleportLocations = new List<Vector3>();
    

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        velocity = rb2d.velocity;
        
        
        

        if (Input.GetKey(KeyCode.A))
        {
            velocity += speed * Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += speed * Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity += Vector3.up * jump;
        }
        
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
            rb2d.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -1f, 1f));
        }
        rb2d.velocity = velocity;

    }

    public void onClickTeleportButton()
    {
        transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
    }
}
