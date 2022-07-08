using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitButton : MonoBehaviour
{   
    public Button QB;
    // Start is called before the first frame update
    public void Start()
    {
        Button btn = QB.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }

    public void onPress()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
