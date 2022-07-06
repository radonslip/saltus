using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingEnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private GameObject player;

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

        if(willSpawn > 998)
        {
            Debug.Log("Spawn");
            Instantiate(enemy, new Vector2(player.transform.position.x + spawnRange,player.transform.position.y + 5), player.transform.rotation);
        }
    }
}
