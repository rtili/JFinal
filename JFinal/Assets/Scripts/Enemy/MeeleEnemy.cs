using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleEnemy : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _aggroRange;

    void Update()
    {
        if (Vector2.Distance(transform.position, _player.position) <= _aggroRange)
        {
            Vector3 direction = (_player.position - transform.position).normalized;
            transform.position += direction * _speed * Time.deltaTime;
        }
    }
}
