using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    int coins = 0;

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void addCoins()
    {
        coins = coins + 1;
        Debug.Log("Собрана 1 манетка");
    }
}
