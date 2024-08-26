using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeEnemy : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _projectileSpawnPoint;

    [SerializeField] private float _aggroRange;
    [SerializeField] private float _weaponDamage;
    [SerializeField] private float _projectileSpeed;

    [SerializeField] private AudioSource _enemyAudioSrc;
    [SerializeField] private AudioClip _enemyShootSound;

    private bool _isReady = false;

    void Update()
    {
        if (Vector2.Distance(transform.position, _player.position) <= _aggroRange && !_isReady)
        {
            StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        _isReady = true;
        yield return new WaitForSeconds(1);

        GameObject projectile = ObjectPool.Instance.SpawnFromPool("Spear", _projectileSpawnPoint.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().AddForce((_player.position - transform.position) * _projectileSpeed, ForceMode2D.Impulse);
        projectile.GetComponent<Projectile>().Damage = _weaponDamage;

        float angle = Mathf.Atan2(_player.position.y, _player.position.x) * Mathf.Rad2Deg;
        projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

        _enemyAudioSrc.PlayOneShot(_enemyShootSound);
        yield return new WaitForSeconds(1);
        _isReady = false;
    }
}
