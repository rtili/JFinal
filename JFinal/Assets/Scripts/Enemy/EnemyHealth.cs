using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable, IDeath
{
    [SerializeField] private float _maxHP;
    [SerializeField] private AudioSource _enemyAudioSrc;
    [SerializeField] private AudioClip _hitSound;

    public event Action DeathEvent;
    private float _hP;

    void Start()
    {
        _hP = _maxHP;
    }

    public void TakeDamage(float damage)
    {
        _hP -= damage;
        _enemyAudioSrc.PlayOneShot(_hitSound);
        Death();
    }

    public void Death()
    {
        if (_hP <= 0)
            DeathEvent?.Invoke();
    }
}
