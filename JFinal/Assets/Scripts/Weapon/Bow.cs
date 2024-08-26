using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : LongRangeWeapon
{
    public override void Shoot()
    {
        GameObject projectile = ObjectPool.Instance.SpawnFromPool("Arrow", _projectileSpawnPoint.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().AddForce(MousePosition() * _projectileSpeed, ForceMode2D.Impulse);
        projectile.GetComponent<Projectile>().Damage = _projectileDamage;

        float angle = Mathf.Atan2(MousePosition().y, MousePosition().x) * Mathf.Rad2Deg;
        projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

        _weaponAudioSrc.PlayOneShot(_weaponShootSound);
    }
}
