using UnityEngine;

public class addingforce : MonoBehaviour 
{
	public float thrust;
	public Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		rb.AddForce(Vector3.forward * thrust);
	}
}