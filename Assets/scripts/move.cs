using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int moveSpeed;
    public int jumpForce;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            body.velocity = new Vector2(0,jumpForce);
        }

        float vecX = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(vecX * moveSpeed, body.velocity.y);



    }
}
