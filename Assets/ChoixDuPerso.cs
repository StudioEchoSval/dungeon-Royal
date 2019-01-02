using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixDuPerso : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
