using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyBoi : MonoBehaviour {
    
    public Vector3 velocity = new Vector3(0, 0, 0);
    float timer = 0;
    float fullTime = .25f;
    [SerializeField]
    GameObject ballprefab;
    [SerializeField]
    public Vector3 velocity1 = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start () {
        //velocity = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
        velocity.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += velocity * Time.deltaTime;

        if (transform.position.x < -1.75f)
        {
            velocity = Vector3.Reflect(velocity1, Vector3.right);
            
            

        }
        if (transform.position.x > 1.75f)
        {
            velocity = Vector3.Reflect(velocity1, Vector3.left);

        }
        if (transform.position.y < -1f)
        {
            velocity = Vector3.Reflect(velocity1, Vector3.up);

        }
        if (transform.position.y > 1f)
        {
            velocity = Vector3.Reflect(velocity1, Vector3.down);

        }
        timer += Time.deltaTime;

        if (timer > fullTime)
        {
            GetComponent<SpriteRenderer>().color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
            timer = 0;
        }

    }

    private GameObject Instantiate(object ballprefab)
    {
        throw new NotImplementedException();
    }
}
