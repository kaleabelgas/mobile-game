using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyScript : MonoBehaviour
{
    private float coins;
    private float gems;

    public void AddCoins(float amount)
    {
        coins += amount;
    }

    public void SubtractCoins(float amount)
    {
        coins -= amount;
    }

    public void AddGems(float amount)
    {
        gems += amount;
    }
    public void SubtractGems(float amount)
    {
        gems -= amount;
    }

    public float Coins
    {
        get { return coins; }
    }
    public float Gems
    {
        get { return gems; }
    }
}
