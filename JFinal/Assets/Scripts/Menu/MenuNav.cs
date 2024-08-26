using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel, _settingsPanel, _exitPanel;
    [SerializeField] private AudioClip _clickSound;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        _menuPanel.SetActive(false);
        _settingsPanel.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(_clickSound);
    }

    public void Exit()
    {
        _menuPanel.SetActive(false);
        _exitPanel.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(_clickSound);
    }
}
