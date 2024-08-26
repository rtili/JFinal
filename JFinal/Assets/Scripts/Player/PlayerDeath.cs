using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private PlayerHealth _pH;

    private void Start()
    {
        _pH.DeathEvent += OnDeath;
    }

    private void OnDeath()
    {
        SceneManager.LoadScene(2);
    }
}
