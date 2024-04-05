using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volumecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer musicmixer;
    public AudioMixer soundmixer;
    public Slider Musicslider;
    public Slider soundslider;
    public GameObject son;
    public GameObject soff;
    public GameObject mon;
    public GameObject moff;
    void Start()
    {
        if (PlayerPrefs.GetInt("fopensound") == 0)
        {
            PlayerPrefs.SetFloat("MusicVolpp", 1f);
            PlayerPrefs.SetFloat("SoundVolpp", 1f);
            PlayerPrefs.SetInt("fopensound", 1);
        }
        musicmixer.SetFloat("MusicVol", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolpp")) * 20);
        soundmixer.SetFloat("SoundVol", Mathf.Log10(PlayerPrefs.GetFloat("SoundVolpp")) * 20);
        Musicslider.value = PlayerPrefs.GetFloat("MusicVolpp");
        soundslider.value = PlayerPrefs.GetFloat("SoundVolpp");
        if (PlayerPrefs.GetFloat("MusicVolpp") < 0.0003f)
        {
            moff.SetActive(true);
            mon.SetActive(false);
        }
        else
        {
            moff.SetActive(false);
            mon.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("SoundVolpp") < 0.0003f)
        {
            soff.SetActive(true);
            son.SetActive(false);
        }
        else
        {
            soff.SetActive(false);
            son.SetActive(true);
        }
       
    }
    public void MusicVolume(float val)
    {
        val = Musicslider.value;
        if (val == 0)
        {
            val = 0.0001f;
        }
        musicmixer.SetFloat("MusicVol", Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("MusicVolpp", val);
        if (val < 0.0003f)
        {
            moff.SetActive(true);
            mon.SetActive(false);
        }
        else
        {
            moff.SetActive(false);
            mon.SetActive(true);
        }
    }
    public void SoundVolume(float val)
    {
        val = soundslider.value;
        if (val == 0)
        {
            val = 0.0001f;
        }
        soundmixer.SetFloat("SoundVol", Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("SoundVolpp", val);
        if (val < 0.0003f)
        {
            soff.SetActive(true);
            son.SetActive(false);
        }
        else
        {
            soff.SetActive(false);
            son.SetActive(true);
        }
    }
    
}
