using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shots : MonoBehaviour
{
    [SerializeField]
    float velocity = .1f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, velocity, 0);
        if (transform.position.y > 1)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D ShotC)
    {

        if (ShotC.gameObject.CompareTag("mushroom") || ShotC.gameObject.CompareTag("Millipede"))
        {
            Destroy(gameObject);

        }






    }
}
