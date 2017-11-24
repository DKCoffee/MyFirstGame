using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirectionTrigger : MonoBehaviour {

    public enum TriggerSide
    {
        RIGHT,
        LEFT
    };

    [SerializeField]
    private TriggerSide side = TriggerSide.RIGHT;

    private EnnemyScript enemy;

    private void Start()
    {
        enemy = GetComponentInParent<EnnemyScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Limit")
        {
            if (side == TriggerSide.RIGHT)
                enemy.changeDirection(EnnemyScript.WalkingDirection.LEFT);
            else if (side == TriggerSide.LEFT)
                enemy.changeDirection(EnnemyScript.WalkingDirection.RIGHT);

        }
    }
}
