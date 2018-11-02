using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    Vector3 goalVector = new Vector3();
    float hspeed = 3;
    float vspeed = 1.2f;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

    }

    // Update is called once per frame
    void Update()
    {

        goalVector += new Vector3(player.GetComponent<Rigidbody2D>().velocity.x, player.GetComponent<Rigidbody2D>().velocity.y, 0);
        Vector3 velocity = goalVector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed, velocity.y * Time.deltaTime * vspeed, 0); 
    }
}
