using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    [SerializeField] private float _healPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IHeal heal))
        {
            heal.UseHeal(_healPoints);
            gameObject.SetActive(false);
        }
    }
}
