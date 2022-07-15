using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backButton2 : MonoBehaviour
{
    public Button LBB;
    public void Start () {
        Button btn = LBB.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }
    public void onPress(){
        // Debug.Log("Press");
        SceneManager.LoadScene(sceneName:"levelSelect");
        
    }
}
