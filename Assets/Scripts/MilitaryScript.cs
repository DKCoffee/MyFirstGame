using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilitaryScript : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] private GunScript gunScript;

    // Use this for initialization
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFire()
    {
        gunScript.StartShoot();
    }
}
