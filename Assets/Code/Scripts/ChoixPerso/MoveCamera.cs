using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {


    public float posPerso;
    public Camera camera;

    public void ChoixPerso()
    {
        Vector3 position = camera.transform.position;
        
        position.x = posPerso;
        
        camera.transform.position = position;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
}
