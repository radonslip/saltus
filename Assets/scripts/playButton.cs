
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{
    public Button PB;
    public void Start () {
        Button btn = PB.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }
    void onPress(){
        SceneManager.LoadScene(sceneName:"testMapWet");
        
    }
}

