using UnityEngine;
using System.Collections;

public class removeForces : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "stopper")
        {
            Destroy(GetComponent<addingforce>());
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
