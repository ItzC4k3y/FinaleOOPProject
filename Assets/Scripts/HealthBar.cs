using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthBarSlider;

    public void InitHpBar(float hp)
    {
        healthBarSlider.maxValue = hp;
        healthBarSlider.value = hp;
    }

    public void UpdateHp(float hp)
    {
        healthBarSlider.value = hp;
    }

    public void HealthBarFlip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
}
