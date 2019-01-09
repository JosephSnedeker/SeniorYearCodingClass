using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 velocity = new Vector3(0, 0, 0);
    [SerializeField]
    float speed = 4;
    [SerializeField]
    float jump = 4;
    Rigidbody2D rb2d;
    [SerializeField]
    float gravity = 0;
    
    Collider2D playerC;
    Collider2D groundC;
    bool onGround;
    Vector3 placeholder;
    bool wallTouchLeft = false;
    bool wallTouchRight = false;
    public float look = 1;
    
   
    int jumpCount = 2;
    


    // Use this for initialization
    void Start()
    {
        playerC = GetComponent<BoxCollider2D>();
        groundC = GameObject.Find("Ground").GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D landright = Physics2D.Raycast(transform.position - new Vector3(-.04f, .05f, 0), new Vector2(0, velocity[1]), Mathf.Abs(velocity[1]));
        RaycastHit2D landleft = Physics2D.Raycast(transform.position - new Vector3(.04f, .05f, 0), new Vector2(0, velocity[1]), Mathf.Abs(velocity[1]));
        Debug.DrawRay(transform.position - new Vector3(-.04f, .05f, 0), new Vector2(0, velocity[1]), new Color (255, 0, 0));
        // landing
        if (landleft.collider || landright.collider)
        {

            placeholder = transform.position;
            placeholder[1] -= landleft.distance;
            transform.position = placeholder;
            velocity[1] = 0;
            jumpCount = 2;

            Debug.Log("on ground");
            onGround = true;
        }

        else
        {
            Debug.Log("not on ground");
            velocity[1] -= gravity * Time.deltaTime;
            onGround = false;
        }





        RaycastHit2D wallHitLeftBottom = Physics2D.Raycast(transform.position - new Vector3(.05f, -.04f, 0), new Vector2(-1, 0), -velocity[0]);
        if (wallHitLeftBottom.collider == true)
        {
            placeholder = transform.position;
            placeholder[0] -= wallHitLeftBottom.distance;
            transform.position = placeholder;
            velocity[0] = 0;
            wallTouchLeft = true;
           
            Debug.Log("touching wall");

        }
        else
        {
            wallTouchLeft = false;
        }
        //hitting wall with right side

        RaycastHit2D wallHitRightTop = Physics2D.Raycast(transform.position - new Vector3(.05f, .04f, 0), new Vector2(-1, 0), -velocity[0]);
        if (wallHitRightTop.collider == true)
        {
            placeholder = transform.position;
            placeholder[0] -= wallHitRightTop.distance;
            transform.position = placeholder;
            velocity[0] = 0;
            wallTouchLeft = true;

            Debug.Log("touching wall");

        }
        else
        {
            wallTouchLeft = false;
        }
        RaycastHit2D wallHitRightBottom = Physics2D.Raycast(transform.position + new Vector3(.05f, -.04f, 0), new Vector2(1, 0), velocity[0]);
        if (wallHitRightBottom.collider == true)
        {
            placeholder = transform.position;
            placeholder[0] += wallHitRightBottom.distance;
            transform.position = placeholder;
            velocity[0] = 0;
            wallTouchRight = true;

            Debug.Log("touching wall");

        }
       

        if (!wallTouchLeft)
        {
            if (Input.GetKey(KeyCode.A))
            {
                moveleft();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {

        }
        if (!wallTouchRight)
        {
            if (Input.GetKey(KeyCode.D))
            {
                moveright();
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpUp();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            landright = Physics2D.Raycast(transform.position - new Vector3(-.04f, .05f, 0), new Vector2(0, velocity[1]), -velocity[1]);
            landleft = Physics2D.Raycast(transform.position - new Vector3(.04f, .05f, 0), new Vector2(0, velocity[1]), -velocity[1]);
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            velocity[0] = 0;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.A))
        {
            velocity[0] = 0;
            moveleft();
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
        {
            velocity[0] = 0;
            moveright();
        }
        if (Input.GetKeyUp(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            velocity[0] = 0;
            moveright();
        }
        if (Input.GetKeyUp(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            velocity[0] = 0;
            moveleft();
        }
      




        velocity[0] = Mathf.Clamp(velocity[0], -.25f, .25f);
        velocity[1] = Mathf.Clamp(velocity[1], -.25f, .25f);
        transform.position += velocity;
        Debug.Log(velocity[0]);

        

    }
    void moveright()
    {
        velocity = speed * Vector3.right * Time.deltaTime;
        look = 1;
    }
    void moveleft()
    {
        velocity = speed * Vector3.left * Time.deltaTime;
        look = -1;
    }
    void jumpUp()
    {
        if (jumpCount > 0)
        {
            velocity[1] = jump * Time.deltaTime;
            


            
            
        }        
        
       
    }



}