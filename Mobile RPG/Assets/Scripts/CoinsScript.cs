using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public class CoinsScript : MonoBehaviour
{
    [SerializeField] private float coinValue;
    public UnityEvent CoinAbsorbed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CurrencyScript.UpdateCoins(coinValue);
            CoinAbsorbed?.Invoke();
            Debug.Log("Picked");
            //Destroy(gameObject);

            // TODO: Magnetic coins towards player
        }

    }
}
