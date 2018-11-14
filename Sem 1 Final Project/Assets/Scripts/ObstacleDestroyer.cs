using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y - GameManager.Instance.MyCharacter.transform.position.y > 4)
        {
            Destroy(gameObject);
        }
	}
}
