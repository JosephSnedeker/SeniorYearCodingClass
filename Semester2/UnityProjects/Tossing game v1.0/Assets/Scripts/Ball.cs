using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 tossDirection;
    Vector3 initialToss;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameManager.Instance.player.transform.position;
        
        rb = GetComponent<Rigidbody>();
        initialToss = new Vector3(0, 1, 1);
        tossDirection = GameManager.Instance.playerCam.transform.forward;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.MovePosition(rb.transform.position + tossDirection  - new Vector3(0, .5f, 0));
        
    }
}
