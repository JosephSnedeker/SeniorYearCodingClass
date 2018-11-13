using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ObstacleSpawner : MonoBehaviour {
    [SerializeField]
    GameObject[] obstacle;
    System.Random rand = new System.Random();
    
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y - 2.64 - GameManager.Instance.MyCharacter.transform.position.y > 4f)
        {
            int rando = rand.Next(0, 3);
            GameObject obstacle1 = Instantiate(obstacle[rando]);
            obstacle1.transform.position = transform.position; 
        }
	}
}
