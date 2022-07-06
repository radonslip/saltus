using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCol : gameManager
{
    public GameObject target;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            deathSound.Play();
            Destroy(target);
            Destroy(gameObject);
        }
        else if(other.tag == "ground")
        {
            Destroy(gameObject);
        }
        else if(other.tag == "enemy")
        {
            Destroy(gameObject);
        }

    }
}
