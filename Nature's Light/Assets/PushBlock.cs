using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBlock : MonoBehaviour {

    public int speed;
    private bool pushedRight;
    private bool pushedLeft;
    private bool pushedUp;
    private bool pushedDown;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update ()
    {
        if ((Input.GetKey("up") || Input.GetKey("w")) && pushedUp)
        {
            transform.Translate(0, 1, 0);
        }
        if ((Input.GetKey("down") || Input.GetKey("s")) && pushedDown)
        {
            transform.Translate(0, -1, 0);
        }
        if ((Input.GetKey("left") || Input.GetKey("a")) && pushedLeft)
        {
            transform.Translate(-1, 0, 0);
        }
        if ((Input.GetKey("right") || Input.GetKey("d")) && pushedRight)
        {
            transform.Translate(1, 0, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey("up") || Input.GetKey("w"))
            {
                pushedUp = true;
            }
            if (Input.GetKey("down") || Input.GetKey("s"))
            {
                pushedDown = true;
            }
            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                pushedLeft = true;
            }
            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                pushedRight = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pushedRight = false;
        pushedLeft = false;
        pushedUp = false;
        pushedDown = false;
    }
}
