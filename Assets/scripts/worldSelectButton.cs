using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class worldSelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    public static string loadedWorld = "0";
    public int worldId;
    public Button WSB;
    public void Start()
    {
        Button btn = WSB.GetComponent<Button>();
        
        btn.onClick.AddListener(onPress);
        
    }

    // Update is called once per frame
    public void onPress()
    {
        var ButtonText = WSB.GetComponentInChildren<Text>();
        Debug.Log(ButtonText.text);

        
        if(worldId == 1)
        {
            loadedWorld = "1";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (worldId == 2)
        {       
                loadedWorld = "2";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (worldId == 3)
        {
            loadedWorld = "3";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (worldId == 4)
        {
            loadedWorld = "4";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }  
        }

    }

