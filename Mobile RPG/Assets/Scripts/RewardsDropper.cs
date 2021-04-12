using UnityEngine;

[RequireComponent(typeof(HealthScript))]
public class RewardsDropper : MonoBehaviour
{
    [SerializeField] RewardsAmount rewards;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject experience;

    private int amountOfCoinsToDrop;
    private int amountOfExpToDrop;
    private HealthScript healthScript;
    private void Start()
    {
        healthScript = GetComponent<HealthScript>();
        amountOfExpToDrop = rewards.Experience;
        amountOfCoinsToDrop = rewards.Coins;

        healthScript.OnDeath += DropCoins;
        healthScript.OnDeath += DropExp;
    }

    public void DropCoins()
    {
        for(int i = 0; i < amountOfCoinsToDrop; i++)
        {
            Instantiate(coin, gameObject.transform);
            Debug.Log("Dropped!");
        }
    }

    public void DropExp()
    {
        for(int i = 1; i< amountOfExpToDrop; i++)
        {
            Instantiate(experience, gameObject.transform);
            Debug.Log("Dropped!");
        }
    }
}
