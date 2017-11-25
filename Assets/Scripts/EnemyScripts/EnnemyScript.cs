using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    public enum EnemyState
    {
        WALK,
        SHOOT
    }

    public enum WalkingDirection
    {
        RIGHT,
        LEFT
    }

    [SerializeField] private GameObject gun;
    [SerializeField] private GunScript gunScript;

    [SerializeField]
    private Transform initialPosition;
    [SerializeField]
    private float movingSpeed;

    private EnemyState enemyState = EnemyState.WALK;
    private WalkingDirection walkDirection = WalkingDirection.LEFT;

    private bool isTouched = false;

    private GameManager gameManager;

    [Header("Sounds")]
    [SerializeField]
    private MultiSoundsRandom soundsHit;
    private void Awake()
    {
        soundsHit = GetComponent<MultiSoundsRandom>();
    }
    // Use this for initialization
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
    }
    // Update is called once per frame
    void Update ()
    {
        switch (enemyState)
        {
            case EnemyState.WALK:
                switch (walkDirection)
                {
                    case WalkingDirection.LEFT:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                        break;
                    case WalkingDirection.RIGHT:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                        break;
                }
                break;

            case EnemyState.SHOOT:
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                break;
        }
        
        
    }

    public void changeDirection(WalkingDirection newDir)
    {
        walkDirection = newDir;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isTouched)
        {
            if (collision.tag == "HitPlayer")
            {
                
                gun.gameObject.SetActive(true);
                enemyState = EnemyState.SHOOT;
                gunScript.StartShoot();
                Destroy(collision.gameObject);
                StartCoroutine(Flasch());
                Flasch();
                isTouched = true;
                gameManager.AddScore();
                soundsHit.PlaySound();
            }

        }
       
    }

}
