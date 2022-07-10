using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class gameData
{
    public bool sOM;
    public int level;

    public gameData (gameManager gm)
    {
        sOM = gm.sOM;
        level = gm.level;
    }

}
