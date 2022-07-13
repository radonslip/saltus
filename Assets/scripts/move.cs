using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : gameManager
{

    public int moveSpeed;
    public int jumpForce;
    private Rigidbody2D body;
    private BoxCollider2D coll;
    public Animator anim;
    public AudioSource music;
    public AudioSource deathSound;
    private gameManager gm;


    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private LayerMask deathZone;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "enemy")
        {
            deathSound.Play();
            music.Stop();
            Destroy(other.transform.parent.gameObject);
            Destroy(gameObject);
            gm.isAlive = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();

        gm = GameObject.Find("gameManager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && onGround())
        {
            body.velocity = new Vector2(body.velocity.x,jumpForce);
        }

        // if(death())
        // {
        //     music.Stop();
        //     deathSound.Play();
        //     Destroy(gameObject);
        //     gm.isAlive = false;
        // }

    }

    void FixedUpdate()
    {


        float vecX = Input.GetAxis("Horizontal");
        float vecY = body.velocity.y;


        body.velocity = new Vector2(vecX * moveSpeed, body.velocity.y);

        anim.SetFloat("speed", Mathf.Abs(vecX));
        anim.SetFloat("ySpeed", vecY);
        anim.SetBool("onG", onGround());

        if(death())
        {
            music.Stop();
            deathSound.Play();
            Destroy(gameObject);
            gm.isAlive = false;
        }


        


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

    private bool death()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .01f, deathZone);
    }
}
