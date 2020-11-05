using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour {

    public float spee;
    public float speedH;
    private float rot;
    private float rot2;
    private Vector3 offset;

	void Start()
    {
        transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }
	void Update ()
    {

        rot += speedH * Input.GetAxis("Mouse X");
      
         transform.eulerAngles = new Vector3(-rot2, rot, 0.0f);
   

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(spee * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-spee * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0, -spee * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, spee * Time.deltaTime));
        }
    }
}
