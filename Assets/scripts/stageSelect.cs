using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stageSelect : MonoBehaviour
{
    public Button SSB;
    private gameManager gm;
    public int buttonID;
    // Start is called before the first frame update
    // void Start()
    // {
    //     Button btn = SSB.GetComponent<Button>();
    //     var ButtonColour = SSB.GetComponent<SpriteRenderer>();
    //     Debug.Log(worldSelectButton.loadedWorld);
    //     btn.onClick.AddListener(onPress);
    //     gm = GameObject.Find("gameManager").GetComponent<gameManager>();

    //     // if(worldSelectButton.loadedWorld == "1")
    //     // {
    //     //     if(gm.level > buttonID)
    //     //     // {
    //     //     //     this.SpriteRenderer.color = "#000000";
    //     // }
    //     // else if(worldSelectButton.loadedWorld == "2")
    //     // {
    //     //     if(gm.level <4)
    //     //     {
            
    //     //     }
    //     //     else if(gm.level <5)
    //     //     {
                
    //     //     }
    //     //     else if(gm.level <6)
    //     //     {
               
    //     //     }
    //     // }
    //     // else if(worldSelectButton.loadedWorld == "3")
    //     // {
    //     //     if(gm.level <7)
    //     //     {

    //     //     }
    //     //     else if(gm.level <8)
    //     //     {
                
    //     //     }
    //     //     else if(gm.level <9)
    //     //     {
               
    //     //     }
    //     // else if(worldSelectButton.loadedWorld == "4")
    //     // {
    //     //     if(gm.level <10)
    //     //     {
              
    //     //     }
    //     //     else if(gm.level <11)
    //     //     {
               
    //     //     }
    //     //     else if(gm.level <12)
    //     //     {

 
    //     //     }
    //     // }
    //     }
    // }
    // Update is called once per frame
   public void onPress()
    {
        var ButtonText = SSB.GetComponentInChildren<Text>();
        Debug.Log(ButtonText.text);

        
        if(worldSelectButton.loadedWorld == "1")
        {
            Debug.Log("world 1");
            if(ButtonText.text == "stage1")
            {
                Debug.Log("1-1");
                SceneManager.LoadScene(sceneName:"beachLevel1");
            }
            else if(ButtonText.text == "stage2")
            {
                Debug.Log("1-2");
                SceneManager.LoadScene(sceneName:"beachLevel2");
            }
            else if(ButtonText.text == "stage3")
            {
                Debug.Log("1-3");
                SceneManager.LoadScene(sceneName:"beachLevel3");
            }
        }
        else if(worldSelectButton.loadedWorld == "2")
        {
            if(ButtonText.text == "stage1")
            {
                Debug.Log("2-1");
                SceneManager.LoadScene(sceneName:"forestLevel1");
            }
            else if(ButtonText.text == "stage2")
            {
                Debug.Log("2-2");
                SceneManager.LoadScene(sceneName:"forestLevel2");
            }
            else if(ButtonText.text == "stage3")
            {
                Debug.Log("2-3");
                SceneManager.LoadScene(sceneName:"forestLevel3");
            }
        }
        else if(worldSelectButton.loadedWorld == "3")
        {
            if(ButtonText.text == "stage1")
            {
                Debug.Log("3-1");
                SceneManager.LoadScene(sceneName:"mountainLevel1");
            }
            else if(ButtonText.text == "stage2")
            {
                Debug.Log("3-2");
                SceneManager.LoadScene(sceneName:"mountainLevel2");
            }
            else if(ButtonText.text == "stage3")
            {
                Debug.Log("3-3");
                SceneManager.LoadScene(sceneName:"mountainLevel3");
            }
        else if(worldSelectButton.loadedWorld == "4")
        {
            if(ButtonText.text == "stage1")
            {
                Debug.Log("4-1");
                SceneManager.LoadScene(sceneName:"templeLevel1");
            }
            else if(ButtonText.text == "stage2")
            {
                Debug.Log("4-2");
                SceneManager.LoadScene(sceneName:"templeLevel2");
            }
            else if(ButtonText.text == "stage3")
            {
                Debug.Log("4-3");
                SceneManager.LoadScene(sceneName:"templeLevel3");
            }
        }
        }
    }
}
