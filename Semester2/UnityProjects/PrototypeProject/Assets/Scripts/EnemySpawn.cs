using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]
    GameObject enemyPrefab;
    float timer = 0;
    float spawnRate = .0000000001f;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            Instantiate(enemyPrefab);
            timer = 0;
            spawnRate *= .98f;
        }
        spawnRate *= .7f;
    }
}
