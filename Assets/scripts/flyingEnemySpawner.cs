using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingEnemySpawner : gameManager
{
    public GameObject enemy;
    private GameObject player;

    public int spawnPast;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");
        int willSpawn = Random.Range(0,1000);
        int spawnRange = Random.Range(-5,5);

        if(player.transform.position.x > spawnPast)
        {
            if(willSpawn > 998)
            {
                Instantiate(enemy, new Vector2(player.transform.position.x + spawnRange,player.transform.position.y + 5), player.transform.rotation);
            }
        }

    }


}
