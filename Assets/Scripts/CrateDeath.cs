using UnityEngine;
using System.Collections;

//destroys a crate if it touches a endpoint

public class CrateDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnCollisionEnter (Collision collision) {
		if (collision.collider.tag == "crateMuncher") 
		{
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
