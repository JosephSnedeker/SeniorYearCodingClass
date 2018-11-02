using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyBoi : MonoBehaviour {
    Vector3 velocity = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
        velocity = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
        velocity.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += velocity * Time.deltaTime;
	}
}
