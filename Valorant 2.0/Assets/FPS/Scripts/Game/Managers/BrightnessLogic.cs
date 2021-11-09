using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessLogic : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float sliderValue;
    [SerializeField] private Image brightnessPanel;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Brightness", 0.5f);

        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, sliderValue);
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("Brightness", sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, sliderValue);
    }
}
