using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    int coins = 0;
    [SerializeField] private TMP_Text coinsCounter;
    private int coinsCount;
    private Coin[] allCoins;

    void Start()
    {
        allCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None);
        coinsCount = allCoins.Length;
        UpdateCoins();

    }


    public void addCoins()
    {
        coins = coins + 1;
        UpdateCoins();
        
    }

    public void UpdateCoins()
    {
        coinsCounter.text = coins + "/" + coinsCount;
    }
}
