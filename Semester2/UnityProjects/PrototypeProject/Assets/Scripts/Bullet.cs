using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timer = 0;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position += new Vector3(0, 0, 1);
        if (timer > 3)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.tag == "Enemy")
        {
            
            Destroy(gameObject);
            
        }
     
    }
}
