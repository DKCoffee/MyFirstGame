using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {

    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private Transform SpawnTransform;
    [SerializeField] private float TimeToSpawn;
    [SerializeField] private float LasttimeSpawn;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", TimeToSpawn, TimeToSpawn);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void Spawn()
    {
        if(Time.realtimeSinceStartup - LasttimeSpawn > TimeToSpawn)
        {
            Instantiate(EnemyPrefab, SpawnTransform.position, SpawnTransform.rotation);
        }
    }
}
