using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : EnemyBase
{
    [SerializeField] MoveScript moveScript;
    [SerializeField] HealthScript healthScript;
    [SerializeField] MeleeAttackScript attackScript;
    [SerializeField] Entity mole;

    protected override void Start()
    {
        base.Start();
        healthScript.EntityHealth = mole.Health;
    }
    void FixedUpdate()
    {
        if(playerFound)
            moveScript.Move(player.transform.position - transform.position, mole.MoveSpeed);
    }
}
