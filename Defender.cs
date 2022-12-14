using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int coinCost = 100;

    public void AddCoins(int amount)
    {
        FindObjectOfType<CoinDisplay>().AddCoin(amount);
    }

    public int GetCoinCost()
    {
        return coinCost;
    }

}
