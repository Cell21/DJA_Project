using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    //Graphics
    public TMPro.TMP_Dropdown graphicsDropDown;

    //Volume
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mixer;

    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropDown.value);
    }

    public void ChangeMasterVolume()
    {
        mixer.SetFloat("MasterVol", masterVol.value);
    }

    public void ChangeMusicVolume()
    {
        mixer.SetFloat("MusicVol", musicVol.value);
    }

    public void ChangeSFXVolume()
    {
        mixer.SetFloat("SFXVol", sfxVol.value);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

}
