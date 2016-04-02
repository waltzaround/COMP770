/**
 CrateDeath script 
 @author Walter Lim
 @purpose kills stray objects that fall out of the rube goldberg machine
 @date 2 April 2016
 
 OMG DESTROYING THINGS

 */


using UnityEngine;
using System.Collections;


public class CrateDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//We don't need this at the moment...
	}


	void OnCollisionEnter (Collision collision) { //whenever the object touches anything...
		if (collision.collider.tag == "crateMuncher")  // check if it has the tag crateMuncher
        { // if it has the tag... Run the code below
            Destroy (gameObject); //  Destroy the object the script is attached to. 
        }                         //  BANG. BOOM. KAPOOOOW. BOOOOOOOOM.
    }

	// Update is called once per frame
	void Update () {
	//this function is unneccesary at the moment but kept in the event it is needed later on 
	}
}
