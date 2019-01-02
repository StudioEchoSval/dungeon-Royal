using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPosition : MonoBehaviour {

    void OnLevelWasLoaded()
    {
        Camera camera = Camera.main;
        this.transform.position = camera.transform.position;
        Debug.Log(this.transform.position);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
