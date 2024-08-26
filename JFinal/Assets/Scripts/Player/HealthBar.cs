using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _hPBar;
    [SerializeField] private PlayerHealth _pH;

    private void Start()
    {
        _pH.HealthChanged += UpdateHealthBar;
    }

    private void UpdateHealthBar()
    {
        _hPBar.fillAmount = _pH.HP / _pH.MaxHP;
    }
}
