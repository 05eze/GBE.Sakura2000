using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{

    public float threshold;

    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < threshold)
        {
            transform.position = spawnPoint;
            ShopGameManager.health -= 1;
        }
        
    }

        

}
