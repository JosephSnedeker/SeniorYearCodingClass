using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    int velocityx;
    int velocityy;
    GameObject raquet1;
    GameObject raquet2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(velocityx, velocityy, 0);
	}
    public void OnTriggerEnter2D(Collider2D ballc)
    {
        if (ballc.gameObject.CompareTag("raquet"))
        {
            velocityx = ballc.
        }
    }
}
