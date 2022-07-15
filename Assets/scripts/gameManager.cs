using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool isAlive = true;

    public bool sOM;
    public int level;

    void Start()
    {
            gameData data = saveGame.loadGame();
            level = data.level;
            sOM = data.sOM;
            sOM = true;
    }

    void Update()
    {
        if(isAlive == false)
        {
            StartCoroutine("Die");
        }
        // else
        // {
        //     Debug.Log("gffgf");
        // }

    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName: "levelSelect");
    }



}
