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
    float rotateSpeedH = 3.0f;
    float rotateSpeedV = 3.0f;
    float yaw = 0f;
    float pitch = 0f;
    


    // Start is called before the first frame update
    void Start()
    {


        
        rb = GetComponent<Rigidbody>();
        transform.position = GameManager.Instance.player.transform.position + new Vector3(1,0,0);
        GetComponent<Camera>().enabled = false;
        
        initialToss = new Vector3(0, .5f, 0 );
        tossDirection = GameManager.Instance.ballCams[0].transform.forward + initialToss;
        
        GameManager.Instance.ballCount += 1;
        GameManager.Instance.ballCams.Add(GetComponent<Camera>());
    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = GetComponent<Camera>();
        currentFallVelocity += acceleration * Time.deltaTime * Time.deltaTime;
        rb.MovePosition(rb.transform.position + (tossDirection + new Vector3(0, currentFallVelocity, 0)));
        yaw += rotateSpeedH * Input.GetAxis("Mouse X");
        pitch -= rotateSpeedV * Input.GetAxis("Mouse Y");

        cam.transform.eulerAngles = new Vector3(pitch, yaw, 0);
        if (GetComponent<Camera>().enabled && Input.GetKeyDown(KeyCode.X))
        {
            
            
            Destroy(gameObject);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider theCollider = GetComponent<SphereCollider>();
        Camera ballCam = GetComponent<Camera>();
        Debug.Log("a collision has occured");
        if (collision.gameObject.CompareTag("Environment"))
        {
            Camera cam = GetComponent<Camera>();
            acceleration = 0;
            tossDirection = Vector3.zero;
            currentFallVelocity = 0;
            theCollider.enabled = false;
            
            cam.transform.forward = transform.position - collision.contacts[0].point;
            

        }
      
    }
}
