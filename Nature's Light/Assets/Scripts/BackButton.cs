using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    public GameObject htpScreen;
    public GameObject menu;
    public GameObject startButton;
    public GameObject htpButton;
    public GameObject exitButton;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject particles;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        htpScreen.SetActive(false);
        menu.SetActive(true);
        startButton.SetActive(true);
        htpButton.SetActive(true);
        exitButton.SetActive(true);
        light1.SetActive(true);
        light2.SetActive(true);
        light3.SetActive(false);
        light4.SetActive(false);
        particles.SetActive(true);
        gameObject.SetActive(false);
    }
}
