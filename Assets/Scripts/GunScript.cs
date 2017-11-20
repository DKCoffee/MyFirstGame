using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]
    private float bulletSpeed;

    private Transform GunTransform;
    private Vector3 playerPosition;
    private Vector3 direction;
    [SerializeField]
    private GameObject bulletPrefab;



	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        GunTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerPosition = GunTransform.position;
        direction = (playerPosition - transform.position).normalized;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += direction * bulletSpeed * Time.deltaTime;


    }
}
