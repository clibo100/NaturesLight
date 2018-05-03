using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public GameObject panel1;
    public GameObject menu;
    public GameObject htpButton;
    public GameObject exit;
    public GameObject pressEnter;
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
        panel1.SetActive(true);
        pressEnter.SetActive(true);
        menu.SetActive(false);
        htpButton.SetActive(false);
        exit.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        gameObject.SetActive(false);
    }
}
