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
    void Update()
    {
        player = GameObject.Find("player");
        int willSpawn = Random.Range(0,10000);
        int spawnRange = Random.Range(-5,5);

        if(player.transform.position.x > spawnPast)
        {
            if(willSpawn > spawnRate)
            {
                Instantiate(enemy, new Vector2(player.transform.position.x + spawnRange,player.transform.position.y + 5), player.transform.rotation);
            }
        }

    }


}
