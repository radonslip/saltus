using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class worldSelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    public static string loadedWorld = "0";
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

        
        if(ButtonText.text == "ForestButton")
        {
            loadedWorld = "2";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (ButtonText.text == "beachButton")
        {       
                loadedWorld = "1";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (ButtonText.text == "MountainButton")
        {
            loadedWorld = "3";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }
        else if (ButtonText.text == "TempleButton")
        {
            loadedWorld = "4";
                SceneManager.LoadScene(sceneName:"StageSelect");
        }  
        }

    }

