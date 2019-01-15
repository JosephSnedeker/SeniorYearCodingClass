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
        transform.position = GameManager.Instance.player.transform.position;
        
        rb = GetComponent<Rigidbody>();
        initialToss = new Vector3(0, 1, 1);
        tossDirection = GameManager.Instance.playerCam.transform.forward;
        GameManager.Instance.ballCount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentFallVelocity += acceleration * Time.deltaTime * Time.deltaTime;
        rb.MovePosition(rb.transform.position + (tossDirection  + new Vector3(0, currentFallVelocity, 0)));
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Environment"))
        {
            acceleration = 0;
            tossDirection = Vector3.zero;
            currentFallVelocity = 0;
        }

    }
}
