using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class originLoader : gameManager
{
    void Start()
    {
        Cursor.visible = true;
        string path = Application.persistentDataPath + "/gameData.shaft";
        if(File.Exists(path))
        {
            gameData data = saveGame.loadGame();
            level = data.level;
            sOM = data.sOM;
            if(sOM == true)
            {
                SceneManager.LoadScene(sceneName: "mainMenuTest");
            }
            else
            {
                SceneManager.LoadScene(sceneName: "beachOpening");
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName: "beachOpening");
        }


    }

}
