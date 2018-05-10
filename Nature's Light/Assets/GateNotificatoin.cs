using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateNotificatoin : MonoBehaviour {

    public GameObject lockIcon;
    public GameObject firefly;
    public GameObject number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lockIcon.SetActive(true);
        firefly.SetActive(true);
        number.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        lockIcon.SetActive(false);
        firefly.SetActive(false);
        number.SetActive(false);
    }
}
