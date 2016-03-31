using UnityEngine;
using System.Collections;

//destroys a crate if it touches a endpoint

public class lifter : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lift")
        {
            rb.AddForce(Vector3.up * 70,ForceMode.Impulse);
        }
    }


}
