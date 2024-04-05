using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject Mainmenu_panel;
    public GameObject CarSelection_panel;
    public GameObject LevelSelection_panel_basic;
    public GameObject Loading_panel;
    public static int OnDisplayCar;
    public static Mainmenu instance;
    public static int LastselectedCar;
    void Start()
    {
        instance = this;
        OnDisplayCar = LastselectedCar;
    }
    public void Mainmenu_Buttons(string button)
    {
        if (button == "playmenu")
        {
            Mainmenu_panel.SetActive(false);
            CarSelection_panel.SetActive(true);
        }
        else if (button == "carselectionback")
        {
            CarSelection_panel.SetActive(false);
            Mainmenu_panel.SetActive(true);
        }
        else if (button == "carzero")
        {
            OnDisplayCar = 0;
            CarSelection_panel.SetActive(false);
            LevelSelection_panel_basic.SetActive(true);
            LastselectedCar = OnDisplayCar;
        }
        else if (button == "carone")
        {
            OnDisplayCar = 1;
            CarSelection_panel.SetActive(false);
            LevelSelection_panel_basic.SetActive(true);
            LastselectedCar = OnDisplayCar;
        }
        else if (button == "cartwo")
        {
            OnDisplayCar = 2;
            CarSelection_panel.SetActive(false);
            LevelSelection_panel_basic.SetActive(true);
            LastselectedCar = OnDisplayCar;
        }
        else if (button == "modeone")
        {
            PlayerPrefs.SetInt("mode", 0);
            Loading_panel.SetActive(true);
            Invoke("loadlevels", 4.0f);
        }
        else if (button == "modetwo")
        {
            PlayerPrefs.SetInt("mode", 1);
            Loading_panel.SetActive(true);
            Invoke("loadlevels", 4.0f);
        }
        else if (button == "modethree")
        {
            PlayerPrefs.SetInt("mode", 2);
            Loading_panel.SetActive(true);
            Invoke("loadlevels", 4.0f);
        }
        else if (button == "levelsback")
        {
            LevelSelection_panel_basic.SetActive(false);
            CarSelection_panel.SetActive(true);
        }
    }
    public void loadlevels()
    {
        SceneManager.LoadScene("GP");
    }
}
