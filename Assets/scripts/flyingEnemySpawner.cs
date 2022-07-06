using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingEnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int willSpawn = Random.Range(0,1000);

        if(willSpawn > 995)
        {
            Debug.Log("Spawn");
            Instantiate(enemy, new Vector2(0,0), player.transform.rotation);
        }
    }
}
