using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollideHit : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IDamageable damage))
        {
            damage.TakeDamage(_damage);
        }
    }
}
