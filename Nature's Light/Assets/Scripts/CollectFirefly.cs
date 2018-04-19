using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFirefly : MonoBehaviour {
    public float speed = 5f;
    public float height = 0.5f;
    public Light lt;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            lt.range = lt.range + 3;
            if (lt.intensity <= (float)0.75)
            {
                lt.intensity += (float)0.3;
            }
            Destroy(gameObject);
        }
    }
}
