using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput() {
        if (Input.GetKey(KeyCode.Space)) { // can thrust while rotating
            print("boost");
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            print("go left");
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            print("go right");
        }
    }
}
