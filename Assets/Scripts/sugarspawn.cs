using UnityEngine;
using System.Collections.Generic;

public class sugarspawn : MonoBehaviour
{
	public GameObject prefab;
	public float sugartimer = 5.0f;
	public void awake()
	{
		InvokeRepeating("spawnSugar", 2f, sugartimer);
	}

	void spawnSugar()
	{
		Instantiate(prefab, new Vector3(2.0f, 0, 0), Quaternion.identity);
}
}