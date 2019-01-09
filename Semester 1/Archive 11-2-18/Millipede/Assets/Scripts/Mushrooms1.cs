using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushrooms1 : MonoBehaviour {
    private float mushroomHealth = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mushroomHealth <= 0)
        {
            Destroy(gameObject);
        }
        if (mushroomHealth == 5)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        }
        else if (mushroomHealth >= 4)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        }
        else if (mushroomHealth >= 3)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 0);
        }
        else if (mushroomHealth >= 2)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);

        }
        else if (mushroomHealth >= 1)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D MushroomC)
    {
        if (MushroomC.gameObject.CompareTag("SHOT"))
        {
            mushroomHealth -= .5f;
        }
    }
}
