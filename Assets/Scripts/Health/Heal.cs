using UnityEngine;

public class Heal : MonoBehaviour
{
   [SerializeField] float heal = 20f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Healht healht = other.GetComponent<Healht>();
            
            if(healht != null)
            {
                healht.addHeal(heal);
            }
        }
    }
}
