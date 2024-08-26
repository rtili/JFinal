using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LongRangeWeapon : MonoBehaviour
{
    [SerializeField] protected float _projectileDamage;
    [SerializeField] protected float _projectileSpeed;
    [SerializeField] protected Transform _projectileSpawnPoint;
    [SerializeField] protected float _fireCooldown;
    [SerializeField] protected AudioSource _weaponAudioSrc;
    [SerializeField] protected AudioClip _weaponShootSound;
   
    public float Cooldown { get { return _fireCooldown; } }

    public abstract void Shoot();

    protected Vector3 MousePosition()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
}
