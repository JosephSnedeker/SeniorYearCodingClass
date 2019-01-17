﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    static GameManager instance;

    public Rigidbody player { get; set; }

    public Vector3 look { get; set; }

    public Camera playerCam { get; set; }

    public List<Camera> ballCams { get; set; }
    
     

    public int ballCount = 0;


    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {

    }
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}  

