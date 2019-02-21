using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (Random.Range(-25, 25), Random.Range(-25, 25), Movement.playerz + 100 + GlobalTimer.globalTimer*10);
        transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0,.1f * GlobalTimer.globalTimer);
        if (transform.position.z < Movement.playerz)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.tag == "Player" || other.tag == "Bullet")
        {

            Destroy(gameObject);
            GlobalTimer.score += 50;

        }
    }
    }
