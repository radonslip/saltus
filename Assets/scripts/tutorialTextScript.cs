using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialTextScript : MonoBehaviour
{
    public GameObject player;

    public int swStage1;
    public int swStage2;

    public string swStage1Text;
    public string swStage2Text;

    public int removeTextAfter;

    void Start()
    {
        this.transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(player.transform.position.x,player.transform.position.y + 1);

        if(player.transform.position.x > swStage2)
        {
            this.GetComponent<UnityEngine.UI.Text>().text = swStage2Text;
        }

        else if(player.transform.position.x > swStage1)
        {
            this.GetComponent<UnityEngine.UI.Text>().text = swStage1Text;
        }

        if(player.transform.position.x > removeTextAfter)
        {
            this.GetComponent<UnityEngine.UI.Text>().text = "";
        }
    }
}
