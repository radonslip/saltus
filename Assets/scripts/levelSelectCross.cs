using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelectCross : MonoBehaviour
{
    public int levelId;
    public GameObject cross;
    private gameManager gmm;
    // Start is called before the first frame update

    void Update()
    {
        gmm = GameObject.Find("gameManager").GetComponent<gameManager>();

        if(worldSelectButton.loadedWorld == "1")
        {
            if(gmm.level >= levelId -1)
            {
                Destroy(cross);
            }


        }
        else if(worldSelectButton.loadedWorld == "2")
        {
            // levelId = levelId + 4;
            if(gmm.level - 2 >= levelId)
            {
                Destroy(cross);
            }


        }
        else if(worldSelectButton.loadedWorld == "3")
        {
            // levelId = levelId + 4;
            if(gmm.level - 5 >= levelId)
            {
                Destroy(cross);
            }


        }
        else if(worldSelectButton.loadedWorld == "4")
        {
            // levelId = levelId + 4;
            if(gmm.level - 8 >= levelId)
            {
                Destroy(cross);
            }


        }
    }
}
