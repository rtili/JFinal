using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public event Action<LongRangeWeapon> WeaponChanged;
    private LongRangeWeapon _weapon;
    private int _selectedWeapon = 0;

    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _selectedWeapon = 0;
            SelectWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _selectedWeapon = 1;
            SelectWeapon();
        }
    }

    private void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == _selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
                _weapon = weapon.gameObject.GetComponent<LongRangeWeapon>();
                WeaponChanged?.Invoke(_weapon);
            }            
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
