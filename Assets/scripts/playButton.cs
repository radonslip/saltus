
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
    public void onPress(){
        // Debug.Log("Press");
        SceneManager.LoadScene(sceneName:"beachLevel1");
        
    }
}

