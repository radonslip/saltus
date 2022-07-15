using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalSceneChange : gameManager
{
    public GameObject player;
    public string targetScene;
    public int levelID;
    private gameManager gm;

    void Start()
    {
        gm = GameObject.Find("gameManager").GetComponent<gameManager>();
        gm.sOM = true;

    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            if(gm.level < levelID)
            {
                gm.level = levelID;
            }
            saveGame.saveData(gm);
            Debug.Log(gm.level);
            SceneManager.LoadScene(sceneName: targetScene);
        }




    }
}
