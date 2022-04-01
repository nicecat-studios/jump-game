using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    void Start(){
        volumeSlider.value = PlayerPrefs.GetFloat("volume", -0.30f);
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("volume", -0.30f));
    }
    
    public void setVolume (float volume){
        PlayerPrefs.SetFloat("volume", volume);
        audioMixer.SetFloat("volume", volume);
    }
}
