using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFirefly : MonoBehaviour {
    public float speed = 5f;
    public float height = 0.5f;
    public Light lt;
    private double intensityMod = 0.1;

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
            lt.range = lt.range + 2;
            if (lt.intensity <= (float)1.0)
            {
                lt.intensity += (float)0.1;
            }
            Destroy(gameObject);
        }
    }
}
