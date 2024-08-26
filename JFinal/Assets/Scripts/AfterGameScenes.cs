using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AfterGameScenes : MonoBehaviour
{
    [SerializeField] private Text _scoreCount;

    private void Start()
    {
        _scoreCount.text = PlayerPrefs.GetInt("Score").ToString();    
    }

    public void InMenu()
    {
        SceneManager.LoadScene(0);
    }
}
