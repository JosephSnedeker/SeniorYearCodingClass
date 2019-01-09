using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Millipede : MonoBehaviour {
    [SerializeField]
    private GameObject mushroom;

    [SerializeField]
    private GameObject millipedeBodyPrefab;
    [SerializeField]
    private GameObject newBody;
    
    private float speed = .01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //give all to body 1
        transform.position += new Vector3(speed, 0, 0);
        if (transform.position.x > 1.775)
        {
            transform.position += new Vector3(-.01f, -.075f, 0);
            speed = -speed;
        }
        if (transform.position.x < -1.775)
        {
            transform.position += new Vector3(0.01f, -.075f, 0);
            speed = -speed;
        }


        
    }
    private void OnTriggerEnter2D(Collider2D millipedeC)
    {
        transform.position += new Vector3(0, -.075f, 0);
        speed = -speed;
        if (millipedeC.gameObject.CompareTag("SHOT"))
        {

            Destroy(gameObject);
            Instantiate(mushroom);
            mushroom.transform.position = transform.position;
        }
    }
}
