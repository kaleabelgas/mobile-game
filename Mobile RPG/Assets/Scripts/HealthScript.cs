using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int EntityHealth { get; set; }
    public void GetDamaged(int damage)
    {
        EntityHealth -= damage;
        if (EntityHealth <= 0)
        {
            Die();
        }
        //TODO: event
    }

    public void Heal(int healAmount)
    {
        EntityHealth += healAmount;
    }

    public void Die()
    {
        Debug.Log("me ded");
        Destroy(gameObject);
    }
}
