using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour {

    public float volumeLevel;
    void Awake()
    {
        GameObject volumeSlider = GameObject.Find("volume_level");
        Slider sliderScript = volumeSlider.GetComponent<Slider>();
        sliderScript.value = volumeLevel = AudioListener.volume;

    }

    public void setVolumeLevel()
    {
        GameObject volumeSlider = GameObject.Find("volume_level");
        Slider sliderScript = volumeSlider.GetComponent<Slider>();
        AudioListener.volume = sliderScript.value;
        if (sliderScript.value == 0)
        {
            GameObject isMute = GameObject.Find("is_mute");
            sliderScript = isMute.GetComponent<Slider>();
            sliderScript.value = 1;
        }
        else
        {
            GameObject isMute = GameObject.Find("is_mute");
            sliderScript = isMute.GetComponent<Slider>();
            sliderScript.value = 0;
        }
    }

    public void setMute()
    {
        GameObject isMute = GameObject.Find("is_mute");
        Slider sliderScript = isMute.GetComponent<Slider>();
        if (sliderScript.value == 0)
        {
            AudioListener.volume = volumeLevel;
        }
        else
        {
            volumeLevel = AudioListener.volume;
            AudioListener.volume = 0.0f;
        }
    }
}
