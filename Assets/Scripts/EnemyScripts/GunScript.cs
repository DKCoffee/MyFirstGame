using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Transform gunTransform;
    [SerializeField] private Transform armEnemy;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    private float timeToFire = 2;

    // Use this for initialization
    void Start ()
    {
        playerTransform = GameObject.Find("Pigeon").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        armEnemy.rotation = Quaternion.LookRotation(Vector3.forward, playerTransform.position - armEnemy.position);
    }

    private IEnumerator Fire()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(timeToFire);
            gunTransform = this.transform;
                GameObject bullet = Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = gunTransform.up * bulletSpeed;
                Destroy(bullet, 5);

        }

    }

    public void StartShoot()
    {
        StartCoroutine(Fire());
    }
    
}
