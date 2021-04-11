using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdaterUI : MonoBehaviour
{
    public Text currentCoins;

    private void Start()
    {
        currentCoins.text = "Coins: " + CurrencyScript.Coins.ToString();
    }

    public void UpdateCoinsUI()
    {
        currentCoins.text = "Coins: " + CurrencyScript.Coins.ToString();
        Debug.Log("Update UI: " + CurrencyScript.Coins.ToString());
    }
}
