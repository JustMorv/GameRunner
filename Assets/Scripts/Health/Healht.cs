using UnityEngine;
using UnityEngine.UI;

public class Healht : MonoBehaviour
{

    [SerializeField] Slider healhtSlider;
    [SerializeField] float maxHealth  = 100f;

    float currenHealh;



    void Start()
    {
        currenHealh = maxHealth;

        healhtSlider.minValue = 0;
        healhtSlider.maxValue = maxHealth;

        UpdateHUD();

        
    }
   public void TakeDamege(float damege)
    {
        currenHealh -= damege;


        UpdateHUD();
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
}
