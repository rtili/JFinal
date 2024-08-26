using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private WeaponHandler _wH;
    [SerializeField] private Image _ammo;
    private LongRangeWeapon _weapon;
    private float _fireRate;

    private void Start()
    {
        _wH.WeaponChanged += SetWeapon;        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (_fireRate <= 0)
            {
                _fireRate = _weapon.Cooldown;
                _weapon.Shoot();
                _ammo.fillAmount = 1;
            }
        if (_fireRate > 0)
        {
            _fireRate -= Time.deltaTime;
            _ammo.fillAmount -= (1 / _fireRate) * Time.deltaTime;
        }
    }

    private void SetWeapon(LongRangeWeapon weapon)
    {
        _weapon = weapon;
        _fireRate = _weapon.Cooldown;
    }
}
