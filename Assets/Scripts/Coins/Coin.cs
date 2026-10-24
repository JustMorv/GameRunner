using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinsManager coins = other.GetComponent<CoinsManager>();

            if (coins != null)
            {
                coins.addCoins();
                Destroy(gameObject);
            }
        }
        
    }
}
