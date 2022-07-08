using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalSceneChange : MonoBehaviour
{
    public GameObject player;
    public string targetScene;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            SceneManager.LoadScene(sceneName: targetScene);
        }


    }
}
