using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float force;
    private Rigidbody rb;

    void Awake ()
    {
        rb = GetComponent<Rigidbody>();
	}

	void Update ()
    {
        rb.AddForce(transform.forward * force);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}
