using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Transform gunTransform;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;

	// Use this for initialization
	void Start ()
    {
        gunTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, playerTransform.position - transform.position);
    }


    //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
}
