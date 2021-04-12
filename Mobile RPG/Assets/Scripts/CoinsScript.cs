using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class CoinsScript : MonoBehaviour
{
    [SerializeField] private float coinValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CurrencyScript.UpdateCoins(coinValue);
            Debug.Log("Picked" + coinValue);
            //Destroy(gameObject);
            // TODO: Magnetic coins towards player
        }

    }
}
