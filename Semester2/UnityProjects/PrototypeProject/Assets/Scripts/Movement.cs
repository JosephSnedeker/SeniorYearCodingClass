using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    Vector3 spaceToMove;
    public static float playerz;
    [SerializeField]
    int speed;
    void Update()
    {
        playerz = transform.position.z;
        spaceToMove = new Vector3 (Input.GetAxis("Strafe"), Input.GetAxis("Altitude"), Input.GetAxis("thrust") ) * speed * Time.deltaTime;
        transform.position += spaceToMove;
        Quaternion rotate = Quaternion.Euler(0, Input.GetAxis("Turn"), 0);
        
        Debug.Log(spaceToMove);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            
        }
    }
}
