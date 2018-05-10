using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int score;
    public Text scoreText;
    public GameObject LLGateText;
    public GameObject LRGateText;
    public GameObject URGateText;
    public GameObject blocks;
    public GameObject blockTemplate;
    public GameObject player;

    // Use this for initialization
    void Start () {
        score = 0;
        LLGateText.GetComponent<TextMesh>().text = "x" + (7 - score);
        LRGateText.GetComponent<TextMesh>().text = "x" + (22 - score);
        URGateText.GetComponent<TextMesh>().text = "x" + (13 - score);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("r"))
        {
            DestroyImmediate(blocks, true);
            blocks = Instantiate(blockTemplate);
            Vector3 newpos = new Vector3(0, 0, -0.1f);
            player.transform.position = newpos;
        }
		
	}

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "x " + score;
        LLGateText.GetComponent<TextMesh>().text = "x" + (7 - score);
        LRGateText.GetComponent<TextMesh>().text = "x" + (22 - score);
        URGateText.GetComponent<TextMesh>().text = "x" + (13 - score);
    }

    public int getScore()
    {
        return score;
    }
}
