using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour, ISetScore, IFinish
{
    [SerializeField] private Text _scoreAmount;
    private int _score;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    public void GetScore(int score)
    {
        _score += score;
        PlayerPrefs.SetInt("Score", _score);
        OnScoreChanged();
    }

    private void OnScoreChanged()
    {
        _scoreAmount.text = _score.ToString();
    }
}
