using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class CoinsScript : MonoBehaviour
{
    private float coinValue;
    private CircleCollider2D circleCollider2D;

    private void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            CurrencyScript.UpdateCoins(coinValue);
    }
}
