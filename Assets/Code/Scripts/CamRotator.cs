using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotator : MonoBehaviour {

    public float rotateSpeed;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
    }

    public void ResetRotation()
    {
        transform.rotation = Quaternion.identity;
    }
}
