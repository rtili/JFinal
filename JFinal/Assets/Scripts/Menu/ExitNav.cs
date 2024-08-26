using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitNav : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel, _exitPanel;
    [SerializeField] private AudioClip _clickSound;

    public void Agree()
    {
        Application.Quit();
    }

    public void Reject()
    {
        _menuPanel.SetActive(true);
        _exitPanel.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(_clickSound);
    }
}
