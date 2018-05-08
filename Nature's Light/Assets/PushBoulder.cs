using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBoulder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("PushableBlock"))
        {
            if ((gameObject.transform.position.x - collision.gameObject.transform.position.x) >= 0.5 
                || (gameObject.transform.position.x - collision.gameObject.transform.position.x) <= 0.5)
            {
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            }

            if ((gameObject.transform.position.y - collision.gameObject.transform.position.y) >= 0.5 
                || (gameObject.transform.position.y - collision.gameObject.transform.position.y) <= 0.5)
            {
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ("PushableBlock"))
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
