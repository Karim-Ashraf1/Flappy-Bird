using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biiiirdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrenth;
    public logicscript logic;
    public bool birdisalive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive )
        {
            logic.flapplay();
            myrigidbody.velocity = Vector2.up * flapstrenth;
        }

        if (transform.position.y>18 || transform.position.y<-18)
        {
            logic.hitplay();
            logic.gameover();
            logic.Quitgame();
            birdisalive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.hitplay();
        logic.gameover();
        logic.Quitgame();
        birdisalive = false;
    }


}
