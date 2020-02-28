using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public string ExposedVolume;

    void Start()
    {
        slider.value = 0.75f;
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat(ExposedVolume, Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(ExposedVolume, sliderValue);
    }
}