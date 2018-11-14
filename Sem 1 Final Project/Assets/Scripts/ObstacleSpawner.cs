using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ObstacleSpawner : MonoBehaviour {
    [SerializeField]
    GameObject[] obstacle;
    System.Random rand = new System.Random();
    GameObject obstacle1;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y - 2.64 - GameManager.Instance.MyCharacter.transform.position.y > 4f)
        {
            int rando = rand.Next(0, 3);
            obstacle1 = Instantiate(obstacle[rando]);
            if (obstacle1 = obstacle[0])
            {
                obstacle1.transform.position = new Vector3(15, GameManager.Instance.MyCharacter.transform.position.y - 100, 0);
            }
            if (obstacle1 = obstacle[1])
            {
                obstacle1.transform.position = new Vector3(-15, GameManager.Instance.MyCharacter.transform.position.y - 100, 0);
            }
            if (obstacle1 = obstacle[2])
            {
                obstacle1.transform.position = new Vector3(5, GameManager.Instance.MyCharacter.transform.position.y - 100, 0);
            }

        }

    }
}
