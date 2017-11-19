using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}

