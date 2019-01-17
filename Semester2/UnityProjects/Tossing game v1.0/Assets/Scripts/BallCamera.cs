using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{
    private Vector3 cameraRotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        camera.enabled = !camera.enabled;
        GameManager.Instance.ballCams.Add(camera);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
