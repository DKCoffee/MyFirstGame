using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PigeonController : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody2D body;
    


    [Header("Shit")]
    [SerializeField]
    private GameObject ShitPrefab;
    [SerializeField]
    private Transform shitTransfom;
    [SerializeField]
    private float shitVelocity = 2;
    [SerializeField]
    private float timeToFire = 5;
    private float lastTimeFire = 0;

    private SpriteRenderer spriteRenderer;

    int rotFlip = 1;

    // Use this for initialization
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal * speed,
                                       moveVertical * speed);

        body.velocity = movement;

        if (Input.GetKeyDown("space"))
        {
            Shit();
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = body.velocity.x > 0;
        if (moveVertical != 0)
        {
            if (body.velocity.x > 0)
            {
                rotFlip = -1;
            }
            else
            {
                rotFlip = 1;
            }
            if (moveVertical < 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotFlip * 25.0f));
            }
            if (moveVertical > 0)
            {
                this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotFlip * -25.0f));
            }
        }
        else
        {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
        }
    }

    private void Shit()
    {
        if(Time.realtimeSinceStartup - lastTimeFire > timeToFire)
        {
            GameObject ShitTest = Instantiate(ShitPrefab, shitTransfom.position, shitTransfom.rotation);
           
            ShitTest.GetComponent<Rigidbody2D>().velocity = shitTransfom.right * shitVelocity;
            Destroy(ShitTest, 5);
            lastTimeFire = Time.realtimeSinceStartup;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene("Defeat");
        }

    }
}
