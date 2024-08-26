using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsNav : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel, _settingsPanel;
    [SerializeField] private AudioClip _clickSound;

    public void BackToMenu()
    {
        _menuPanel.SetActive(true);
        _settingsPanel.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(_clickSound);
    }
}
