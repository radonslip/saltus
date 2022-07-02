using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int moveSpeed;
    public int jumpForce;
    private Rigidbody2D body;
    private BoxCollider2D coll;
    public Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && onGround())
        {
            body.velocity = new Vector2(0,jumpForce);
        }


    }

    void FixedUpdate()
    {


        float vecX = Input.GetAxis("Horizontal");
        float vecY = body.velocity.y;
        body.velocity = new Vector2(vecX * moveSpeed, body.velocity.y);

        anim.SetFloat("speed", Mathf.Abs(vecX));
        Debug.Log(onGround());


        anim.SetFloat("ySpeed", vecY);
        anim.SetBool("onG", onGround());


        


        if(vecX > 0)
        {
            gameObject.transform.localScale = new Vector3(10,10,1);
        }

        else if(vecX < 0)
        {
            gameObject.transform.localScale = new Vector3(-10,10,1);
        }



    }

    private bool onGround()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
