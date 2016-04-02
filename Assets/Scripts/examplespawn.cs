/**
 examplespawn script
 @author Walter Lim
 @purpose spawns objects
 @date 2 April 2016
 
 OMG SPAWNING THINGS

 */
using UnityEngine;

public class examplespawn : MonoBehaviour
{
	public GameObject prefab;

	void Start()
	{
			
		InvokeRepeating("spawningsugar", 0, 0.5F);// start running the spawningsugar function every 0.5 seconds

	}

	void spawningsugar()
	{
		Instantiate(prefab, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z), Quaternion.identity); // create a new gameobject wherever the object this script is atteched to is located. WOOOOOSH.

	}



}