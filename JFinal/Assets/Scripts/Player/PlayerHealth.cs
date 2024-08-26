using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable, IDeath, IHeal
{
    [SerializeField] private float _maxHP;
    [SerializeField] private AudioSource _playerAudioSrc;
    [SerializeField] private AudioClip _hitSound;
    [SerializeField] private AudioClip _healSound;
    public float HP {get { return _hP; } }
    public float MaxHP { get{ return _maxHP; } }
    public event Action HealthChanged;
    public event Action DeathEvent;
    private float _hP;

    void Start()
    {
        _hP = _maxHP;
    }

    public void TakeDamage(float damage)
    {
        _hP -= damage;
        _playerAudioSrc.PlayOneShot(_hitSound);        
        HealthChanged?.Invoke();
        Death();
    }

    public void Death()
    {
        if (_hP <= 0)        
            DeathEvent?.Invoke();        
    }

    public void UseHeal(float healPoints)
    {
        _hP += healPoints;
        _playerAudioSrc.PlayOneShot(_healSound);
        HealthChanged?.Invoke();
    }
}
