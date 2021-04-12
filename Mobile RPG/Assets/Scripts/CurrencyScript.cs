using System;

public class CurrencyScript
{
    private static float coinsAmount;
    private static float gemsAmount;

    public static event Action OnUpdateCoins;

    public static void UpdateCoins(float amount)
    {
        coinsAmount += amount;
        OnUpdateCoins?.Invoke();
    }

    public static void UpdateGems(float amount)
    {
        gemsAmount += amount;
    }

    public static float Coins => coinsAmount;
    public static float Gems => gemsAmount;
}
