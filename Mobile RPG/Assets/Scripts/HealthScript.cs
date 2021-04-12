using System;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public event Action OnDeath;
    public int EntityHealth { get; set; }
    public void GetDamaged(int damage)
    {
        EntityHealth -= damage;
        if (EntityHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healAmount)
    {
        EntityHealth += healAmount;
    }

    public void Die()
    {
        Debug.Log("me ded");
        OnDeath?.Invoke();
        //Destroy(gameObject, 0.1f);
    }
}
