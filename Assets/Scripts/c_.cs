using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_ : MonoBehaviour {

    private bool liga;
    
    void Start() {

        liga = false;
    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetButtonDown("Jump") && liga == false) {

            liga = true;

            gameObject.GetComponent<Animator>().Play("Rotate");
        }
        
        if (Input.GetButtonDown("Jump") && liga == true) {

            liga = false;

            gameObject.GetComponent<Animator>().Play("Off");
        }
	}
}
