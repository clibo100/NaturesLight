using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFirefly : MonoBehaviour {
    public float speed = 5f;
    public float height = 0.5f;
    public Light lt;
    private int scoreValue = 1;
    private GameController gameController;

    // Use this for initialization
    void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
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
            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
    
}
