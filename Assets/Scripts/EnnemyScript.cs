using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    [SerializeField] private GameObject gun;

    [SerializeField]
    private Transform initialPosition;
    [SerializeField]
    private int direction = 1;
    [SerializeField]
    private float maxDist;
    [SerializeField]
    private float minDist;
    [SerializeField]
    private float movingSpeed;

   enum state
    {
        WALK,
        SHOOT
    }
    state stateEnemy = state.WALK;



    // Use this for initialization
    void Start ()
    {
        
        //initialPosition = transform.position;
        direction = -1;
        maxDist += transform.position.x;
        minDist -= transform.position.x;

	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (stateEnemy)
        {
            case state.WALK:
                switch (direction)
                {
                    case -1:
                        //Move Left
                        if (transform.position.x > minDist)
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                        }
                        else
                        {
                            direction = 1;
                        }
                        break;
                    case 1:
                        //Move Right
                        if (transform.position.x < maxDist)
                        {
                            GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody2D>().velocity.y);

                        }
                        else
                        {
                            direction = -1;
                        }
                        break;


                }
                break;

            case state.SHOOT:
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                break;
        }
        
        
    }

    private IEnumerator Flasch()
    {
        for (int i = 0; i < 1; i++)
        {


            GetComponent<SpriteRenderer>().color = Color.clear;
            yield return new WaitForSeconds(.1f);
            GetComponent<SpriteRenderer>().color = Color.red;
            yield return new WaitForSeconds(.1f);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HitPlayer")
        {
            gun.gameObject.SetActive(true);
            stateEnemy = state.SHOOT;
            Destroy(collision.gameObject);
            StartCoroutine(Flasch());
            Flasch();
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.transform.GetComponent<Collider2D>());
        }

    }

}
