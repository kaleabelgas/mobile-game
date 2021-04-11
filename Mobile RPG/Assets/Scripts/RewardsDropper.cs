using UnityEngine;

public class RewardsDropper : MonoBehaviour
{
    [SerializeField] RewardsAmount rewards;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject experience;

    private int amountOfCoinsToDrop;
    private int amountOfExpToDrop;
    private void Start()
    {
        amountOfExpToDrop = rewards.Experience;
        amountOfCoinsToDrop = rewards.Coins;
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
