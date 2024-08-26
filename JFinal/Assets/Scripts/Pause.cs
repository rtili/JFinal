using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pausePlate;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_pausePlate.activeInHierarchy)
            {
                _pausePlate.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                _pausePlate.SetActive(false);
                Time.timeScale = 1;
            }           
        }
    }

    public void InMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
