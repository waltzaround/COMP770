using UnityEngine;
using System.Collections;

public class Garbagecollection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void oncollisionenter(Collision otherObj)
    {
        if (otherObj.collider.tag == "sugar")
        {
            Destroy(otherObj.gameObject);
        }
    }

}
