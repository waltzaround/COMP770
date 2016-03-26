using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {
	Rigidbody body;
	public float speed = 2.0f;

	void FixedUpdate()
	{
		body = GetComponent<Rigidbody>();
		body.position -= transform.forward * speed * Time.deltaTime;
		body.MovePosition (body.position + transform.forward * speed * Time.deltaTime);

	}

}

