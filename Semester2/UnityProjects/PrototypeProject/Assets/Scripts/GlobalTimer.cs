using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static float score;
    public static float globalTimer;
    // Update is called once per frame
    void Update()
    {
        score += .25f;
        globalTimer += Time.deltaTime;
    }
}
