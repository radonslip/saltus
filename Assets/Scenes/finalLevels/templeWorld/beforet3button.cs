using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class beforet3button : MonoBehaviour
{
    public Button play;
    public void Start () {
        Button btn = play.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }
    public void onPress(){
        // Debug.Log("Press");
        SceneManager.LoadScene(sceneName:"templeLevel3");
        
    }
}
