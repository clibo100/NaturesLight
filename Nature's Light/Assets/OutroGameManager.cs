using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroGameManager : MonoBehaviour {

    private int frame;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

	// Use this for initialization
	void Start () {
        frame = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("return"))
        {
            nextFrame();
        }
    }

    public void nextFrame()
    {
        if (frame == 1)
        {
            panel2.SetActive(true);
            panel1.SetActive(false);
        }
        if (frame == 2)
        {
            SceneManager.LoadScene(0);
        }
        frame++;
    }
}
