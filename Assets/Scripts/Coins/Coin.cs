using UnityEngine;

public class Coin : MonoBehaviour
{

    float minSpeed = 200f;
    float maxSpeed = 260f;

    float rotationSpeed;


    void Start()
    {
        rotationSpeed = Random.Range(minSpeed, maxSpeed);
        
    }
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
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
