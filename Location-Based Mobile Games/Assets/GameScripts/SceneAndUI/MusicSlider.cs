using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicSlider : MonoBehaviour
{
    public AudioMixer Mixer;
    public Slider slider;

    public void SetVolume()
    {
        float vol = slider.value;
        Mixer.SetFloat("Vol", Mathf.Log10(vol)*20);
    }
}
