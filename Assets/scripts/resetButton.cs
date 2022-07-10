using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetButton : gameManager
{
    public Button RB;
    public gameManager gm;
    // Start is called before the first frame update
    public void Start()
    {
        gm = GameObject.Find("gameManager").GetComponent<gameManager>();
        Button btn = RB.GetComponent<Button>();
        btn.onClick.AddListener(onPress);
    }

    public void onPress()
    {
        gm.level = 0;
        gm.sOM = false;
        saveGame.saveData(GameObject.Find("gameManager").GetComponent<gameManager>());
        Debug.Log("Reset");
    }
}
