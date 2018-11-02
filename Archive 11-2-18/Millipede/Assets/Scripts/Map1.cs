
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1 : MonoBehaviour
{
    [SerializeField]
    private GameObject mushroom;
    public GameObject newShrooms;
    private int mushroomHealth = 5;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            float shroomPositionx = Random.Range(-177.5f, 177.5f);
            float shroomPostiiony = Random.Range(-80, 100);
            shroomPositionx = shroomPositionx / 100;
            shroomPostiiony = shroomPostiiony / 100;


            Vector3 shroomPostition = new Vector3(shroomPositionx, shroomPostiiony, 0);
            newShrooms = Instantiate(mushroom);
            mushroom.transform.position = shroomPostition;
            
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}








