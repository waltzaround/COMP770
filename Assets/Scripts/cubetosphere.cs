/**
 cubetosphere script 
 @author Walter Lim
 @purpose removes boxcollider component from an object, exposing the sphere collider. This allows cubes to roll around like marble, as they are still being renderred as cubes but do not behave as such.
 @date 2 April 2016
 
 OMG SHAPESHIFTING THINGS

 */


using UnityEngine;
using System.Collections;



public class cubetosphere : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //not used
    }


    void OnCollisionEnter(Collision collision)// if it collides with anything....   
    {
        if (collision.collider.tag == "cubetosphere")//and has the tag cubetosphere...
        {
            Destroy(GetComponent<BoxCollider>());//DESTROY THE BOX COLLIDER. BURN IT WITH LULZ. EXPOSE THE SPHERE COLLIDER THAT HIDES WITHIN.
        }
    }

    // Update is called once per frame
    void Update()
    {
        //not used
    }
}
