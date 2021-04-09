using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CurrencyScript), typeof(CircleCollider2D))]
public class CoinsScript : MonoBehaviour
{
    private float coinValue;
    private CurrencyScript currencyScript;
    private CircleCollider2D circleCollider2D;

    private void Start()
    {
        currencyScript = FindObjectOfType<CurrencyScript>();
        circleCollider2D = FindObjectOfType<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        currencyScript.AddCoins(coinValue);
    }
}
