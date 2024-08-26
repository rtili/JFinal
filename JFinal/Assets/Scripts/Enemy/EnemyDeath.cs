using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private EnemyHealth _eH;

    private void Start()
    {
        _eH.DeathEvent += OnDeath;
    }

    private void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
