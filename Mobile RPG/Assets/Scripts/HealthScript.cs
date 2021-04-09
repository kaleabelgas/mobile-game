using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private Entity entity;

    private int entityHealth;

    private void Start()
    {
        entityHealth = entity.Health;
    }
    public void GetDamaged(int damage)
    {
        entityHealth -= damage;
        if (entityHealth <= 0)
        {
            Die();
        }
        //TODO: event
    }

    public void Heal(int healAmount)
    {
        entityHealth += healAmount;
    }

    public void Die()
    {
        Debug.Log("me ded");
    }
    public int EntityHealth {
        get { return entityHealth; }
    }
}
