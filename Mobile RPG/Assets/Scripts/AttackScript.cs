using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public Transform WeaponTransform { get; set; }
    public LayerMask EnemyMask { get; set; }
    public int Strength { get; set; }
    public float AttackRange { get; set; }

    public void DoAttack()
    {
        Debug.Log("Attacked!" + Strength);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(WeaponTransform.position, AttackRange, EnemyMask);

        foreach(Collider2D enemy in hitEnemies)
        {
            if(enemy.gameObject.CompareTag("Enemy"))
                enemy.GetComponent<HealthScript>().GetDamaged(Strength);
        }
    }
}
