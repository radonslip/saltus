using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{


    public bool sOM;
    public int level;

    void Start()
    {
            gameData data = saveGame.loadGame();
            level = data.level;
            sOM = data.sOM;
            sOM = true;
    }



}
