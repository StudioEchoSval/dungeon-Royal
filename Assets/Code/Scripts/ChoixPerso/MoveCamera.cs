using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public void ChoixPerso()
    {
        Vector3 position = this.transform.position;
        //Debug.Log(this.transform.position);

        if (this.transform.position.x == 20)
            position.x = 0;
        else 
            position.x += 5;

        transform.position = position;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
}
