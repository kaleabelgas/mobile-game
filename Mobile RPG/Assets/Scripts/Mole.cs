using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : EnemyBase
{
    [SerializeField] private int secondsToLookForPlayer = 10;

    [SerializeField] MoveScript moveScript;
    [SerializeField] HealthScript healthScript;
    [SerializeField] AttackScript attackScript;
    [SerializeField] Entity entity;
    void Start()
    {
        
    }

    void Update()
    {

        //VERY basic AI
        if (!playerFound)
            StartCoroutine(LookForPlayer(secondsToLookForPlayer));
        if (playerFound)
            moveScript.Move(player.transform.position - transform.position, entity.MoveSpeed);
    }
}
