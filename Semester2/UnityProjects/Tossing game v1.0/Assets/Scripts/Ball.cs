using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   
    private Rigidbody rb;
    Vector3 tossDirection;
    Vector3 initialToss;
    [SerializeField]
    float acceleration = -2f;
    float currentFallVelocity = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        rb = GetComponent<Rigidbody>();
        transform.position = GameManager.Instance.player.transform.position + new Vector3(1,0,0);
        GetComponent<Camera>().enabled = false;
        
        initialToss = new Vector3(0, .5f, 0 );
        tossDirection = GameManager.Instance.playerCam.transform.forward + initialToss;
        
        GameManager.Instance.ballCount += 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentFallVelocity += acceleration * Time.deltaTime * Time.deltaTime;
        rb.MovePosition(rb.transform.position + (tossDirection + new Vector3(0, currentFallVelocity, 0)));
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider theCollider = GetComponent<SphereCollider>();
        Camera ballCam = GetComponent<Camera>();
        Debug.Log("a collision has occured");
        if (collision.gameObject.CompareTag("Environment"))
        {
            
            acceleration = 0;
            tossDirection = Vector3.zero;
            currentFallVelocity = 0;
            theCollider.enabled = !theCollider.enabled;
            GetComponent<Camera>().enabled = true;
            
        }
    }
}
