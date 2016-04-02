/**
 lifter script 
 @author Walter Lim
 @purpose pushes objects into the air once they collide with a jump platform with this script attached
 @date 2 April 2016
 
 OMG IT'S MAKING THINGS JUMP

 */

using UnityEngine;
using System.Collections;



public class lifter : MonoBehaviour
{
    public float thrust; // this float specifies how much to jump, but isn't used atm
    public Rigidbody rb; //this allows me to write less later on by shortening GetComponent<Rigidbody>()

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // define rb as GetComponent<Rigidbody>()
    }


    void OnCollisionEnter(Collision collision) // if anything collides...
    {
        if (collision.collider.tag == "lift")// and it has the tag lift....
        {
            rb.AddForce(Vector3.up * 70,ForceMode.Impulse); // make it go WOOOOOSH by adding a force of 70 upwards in a single frame. WOOOOOOOOOOOSH
        }
    }


}
