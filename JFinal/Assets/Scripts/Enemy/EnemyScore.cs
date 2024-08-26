using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScore : MonoBehaviour, IGiveScore
{
    [SerializeField] private int _score;
    [SerializeField] private EnemyHealth _eH;
    [SerializeField] private PlayerScore _pS;

    private void Start()
    {
        _eH.DeathEvent += GiveScore;
    }

    public void GiveScore()
    {
        _pS.GetComponent<ISetScore>().GetScore(_score);
    }
}
