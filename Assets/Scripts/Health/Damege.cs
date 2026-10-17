using UnityEngine;

public class Damege : MonoBehaviour
{
    [SerializeField] float damege = 30f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Healht healht = other.GetComponent<Healht>();
            if(healht != null)
            {
                healht.TakeDamege(damege);
            }
        }
    }
   
}
