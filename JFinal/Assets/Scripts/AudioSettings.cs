using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer _masterMixer;
    [SerializeField] private Slider _musicSlider, _sfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SFXVolume") && PlayerPrefs.HasKey("MusicVolume"))
        {
            _masterMixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFXVolume"));
            _masterMixer.SetFloat("Music", PlayerPrefs.GetFloat("MusicVolume"));
            SetSliders();
        }
        else
        {
            SetSliders();
        }
    }

    public void UpdateSFXVolume()
    {
        _masterMixer.SetFloat("SFX", _sfxSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", _sfxSlider.value);
    }

    public void UpdateMusicVolume()
    {
        _masterMixer.SetFloat("Music", _musicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", _musicSlider.value);
    }

    private void SetSliders()
    {
        _sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }
}
