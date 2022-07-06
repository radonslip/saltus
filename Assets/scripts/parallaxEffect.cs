using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxEffect : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float multiplier;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp =  (cam.transform.position.x * (1 - multiplier));
        float dist =  (cam.transform.position.x * multiplier);

        transform.position = new Vector2(startpos + dist, cam.transform.position.y * (1 - multiplier));

        if(temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
