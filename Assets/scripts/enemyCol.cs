using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemyCol : gameManager
{
    private GameObject player;
    public AIPath path;
    public AIDestinationSetter targ;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.Find("player");
        targ.target = player.transform;
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "ground")
        {
            Destroy(gameObject);
        }
        // else if(other.tag == "enemy")
        // {
        //     Destroy(gameObject);
        //     // Debug.Log("Help");
        // }

    }

    void Update()
    {
        if(path.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector2(1f,1f);
        }
        else if(path.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector2(-1f,1f);
        }
    }
}
