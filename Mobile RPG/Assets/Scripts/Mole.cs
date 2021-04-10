using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : EnemyBase
{
    [SerializeField] MoveScript moveScript;
    [SerializeField] HealthScript healthScript;
    [SerializeField] AttackScript attackScript;
    [SerializeField] Entity entity;

    private void Start()
    {
        CheckIfPlayerExists();
    }
    void FixedUpdate()
    {
        if(playerFound)
            moveScript.Move(player.transform.position - transform.position, entity.MoveSpeed);
    }
}
