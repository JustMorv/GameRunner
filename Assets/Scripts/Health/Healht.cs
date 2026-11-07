using UnityEngine;
using UnityEngine.UI;

public class Healht : MonoBehaviour
{

    [SerializeField] Slider healhtSlider;
    [SerializeField] float maxHealth  = 100f;
    Animator animator;
    [SerializeField] Movement movement;

    float currenHealh;
    bool isDead = false;



    void Start()
    {
        currenHealh = maxHealth;
        healhtSlider.minValue = 0;
        healhtSlider.maxValue = maxHealth;
        UpdateHUD();


        animator = GetComponent<Animator>();
    }
   public void TakeDamege(float damege)
    {
        if (isDead) return;
        currenHealh -= damege;
        UpdateHUD();
        if (currenHealh <= 0) {
            Die();
        }

    }
    public void addHeal(float heal)
    {
        currenHealh += heal;
        UpdateHUD();
    }

    void UpdateHUD()
    {
        healhtSlider.value = currenHealh;
    }

    void Die()
    {
        isDead = true;
        Debug.Log("player is dead");
        animator.SetBool("isDead", true);
        movement.enabled = false;

    }
}
