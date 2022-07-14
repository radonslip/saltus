using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingEnemySpawner : gameManager
{
    public GameObject enemy;
    private GameObject player;

    public int spawnPast;
    public int spawnRate;


    // Update is called once per frame
    void FixedUpdate()
    {
        player = GameObject.Find("player");
        int willSpawn = Random.Range(0,10000);
        int spawnRange = Random.Range(-10,10);

        if(player.transform.position.x > spawnPast)
        {
            if(willSpawn > spawnRate)
            {
                Instantiate(enemy, new Vector2(player.transform.position.x + spawnRange,player.transform.position.y + 10), player.transform.rotation);
            }
        }

    }


}
