using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalSceneChange : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            Debug.Log("Wins");
            SceneManager.LoadScene(sceneName:"mainMenuTest");
        }


    }
}
