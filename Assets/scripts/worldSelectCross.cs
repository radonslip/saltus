using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worldSelectCross : MonoBehaviour
{
    public int worldId;
    public GameObject cross;
    private gameManager gmm;
    // Start is called before the first frame update

    void Update()
    {
        gmm = GameObject.Find("gameManager").GetComponent<gameManager>();
        if(gmm.level >= worldId)
        {
            this.transform.position = new Vector2(1000,1000);
        }
    }


}
