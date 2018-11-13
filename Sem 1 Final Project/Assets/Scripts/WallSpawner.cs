using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour {
    


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y - 2.64 - GameManager.Instance.MyCharacter.transform.position.y > 4)
        {
            Vector3 placeholder = transform.position;
            placeholder[1] -= 5.26f * 9;
            transform.position = placeholder;
        }
        

    }
}
