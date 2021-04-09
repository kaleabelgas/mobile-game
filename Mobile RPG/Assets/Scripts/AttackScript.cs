using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField] private Entity entity;
    private bool isNearEnemy;

    private int strength;

    private void Start()
    {
        strength = entity.StrengthValue;
    }
    public void DoAttack()
    {
        Debug.Log("Attacked!" + strength);
    }

    
}
