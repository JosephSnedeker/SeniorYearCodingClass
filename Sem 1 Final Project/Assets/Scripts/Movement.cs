using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Vector3 velocity = new Vector3();
    [SerializeField]
    float speed;
    int look;
    bool ismoveright;
    bool ismoveleft;
    [SerializeField]
    float gravity = 2;
    [SerializeField]
    Animator animator = new Animator();
    public int score = 0;
    // Use this for initialization
    private void Awake()
    {
        GameManager.Instance.MyCharacter = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.A))
            moveleft();
        if (Input.GetKey(KeyCode.D))
            moveright();
        
        velocity[1] -= gravity *Time.deltaTime;
        if (velocity[1] < -1)
            velocity[1] = -1;
        Debug.Log(velocity[1]);
        transform.position += velocity;
        if (velocity[0] > 0)
        {
            ismoveright = true;
            animator.SetBool("TurnRight", true);
            animator.SetBool("TurnLeft", false);
        }
           
    
        else if (velocity[0] < 0)
        {
            ismoveleft = true;
            animator.SetBool("TurnLeft", true);
            animator.SetBool("TurnRight", false);
        }
        Debug.Log(score);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Obstacle"))
        {
            SceneManager.LoadScene("gameover");
            Debug.Log("DED");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "threshold")
        {
            score++;
        }
    }
    void moveright()
    {
        velocity += speed * Vector3.right * Time.deltaTime;
        look = 1;
       

    }
    void moveleft()
    {
        velocity += speed * Vector3.left * Time.deltaTime;
        look = -1;
        
    }
}