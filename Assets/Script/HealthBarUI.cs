using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image healthBarImg;

    public void UpdateHealthBar(PlayerHealth playerHealth)
    {
        healthBarImg.fillAmount = playerHealth.healthPercentage;
    }
}
