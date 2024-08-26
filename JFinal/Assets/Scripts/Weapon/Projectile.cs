using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Damage {set { _damage = value; } }
    private float _damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IDamageable damage))
        {
            damage.TakeDamage(_damage);
        }
        gameObject.SetActive(false);
    }
}
