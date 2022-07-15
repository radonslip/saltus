using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backButton : MonoBehaviour
{
    public Button WBB;
    public void Start () {
        Button btn = WBB.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }
    public void onPress(){
        // Debug.Log("Press");
        SceneManager.LoadScene(sceneName:"mainMenuTest");
        
    }
}
