using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPButton : MonoBehaviour {

    public GameObject htpScreen;
    public GameObject backButton;
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject menu;
    public GameObject light1;
    public GameObject light2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        htpScreen.SetActive(true);
        backButton.SetActive(true);
        startButton.SetActive(false);
        exitButton.SetActive(false);
        menu.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        gameObject.SetActive(false);

    }
}
