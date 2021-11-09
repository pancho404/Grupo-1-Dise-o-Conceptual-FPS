using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeLogic : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float sliderValue;
    [SerializeField] Image imageMute;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("VolumeAudio", 0.5f);
        AudioListener.volume = slider.value;
        Mute();
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("VolumeAudio", sliderValue);
        AudioListener.volume = slider.value;
        Mute();
    }

    public void Mute()
    {
        if (sliderValue == 0)
        {
            imageMute.enabled = true;
        }
        else
        {
            imageMute.enabled = false;
        }
    }
}
