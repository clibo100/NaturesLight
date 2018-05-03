using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneManager : MonoBehaviour {

    private int frame;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject panel7;

    // Use this for initialization
    void Start () {
        frame = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void nextFrame()
    {
        if (frame == 1)
        {
            panel2.SetActive(true);
        }
        if (frame == 2)
        {
            panel3.SetActive(true);
        }
        if (frame == 3)
        {
            panel4.SetActive(true);
        }
        if (frame == 4)
        {
            panel5.SetActive(true);
        }
        if (frame == 5)
        {
            panel6.SetActive(true);
        }
        if (frame == 6)
        {
            panel7.SetActive(true);
        }
        if (frame == 7)
        {
            SceneManager.LoadScene(1);
        }
        frame++;
    }
}
