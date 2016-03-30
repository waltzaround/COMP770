using UnityEngine;

public class examplespawn : MonoBehaviour
{
	public GameObject prefab;

	void Start()
	{
			
		InvokeRepeating("spawningsugar", 0, 0.5F);

	}

	void spawningsugar()
	{
		Instantiate(prefab, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z), Quaternion.identity);

	}



}