using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject pigeon;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - pigeon.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = pigeon.transform.position + offset;
	}
}
