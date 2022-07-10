using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalSceneChange : gameManager
{
    public GameObject player;
    public string targetScene;
    public gameManager gm;

    void Start()
    {
        gm = GameObject.Find("gameManager").GetComponent<gameManager>();
        gm.sOM = true;

    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {

            saveGame.saveData(gm);
            SceneManager.LoadScene(sceneName: targetScene);
        }




    }
}
