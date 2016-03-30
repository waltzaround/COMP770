using UnityEngine;
using System.Collections;

public class PusherTimer : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;
    void Start()
    {
        StartCoroutine(Example());
        rb = GetComponent<Rigidbody>();
    }
    
    IEnumerator Example()
    {
        print(Time.time);
        rb.AddForce(Vector3.left * thrust);
        yield return new WaitForSeconds(5);
        rb.AddForce(Vector3.right * -1 * thrust);
        yield return new WaitForSeconds(5);
        print(Time.time);

    }
}