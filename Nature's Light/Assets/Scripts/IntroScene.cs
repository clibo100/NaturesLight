using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScene : MonoBehaviour {
    public IntroSceneManager intro;
    bool unpressed;

    private GameObject gameControllerObject;


    // Use this for initialization
    void Start () {
        unpressed = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("return") && unpressed)
        {
            StartCoroutine(waiting());
            intro.nextFrame();
            gameObject.SetActive(false);
        }
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(1);
    }
}
