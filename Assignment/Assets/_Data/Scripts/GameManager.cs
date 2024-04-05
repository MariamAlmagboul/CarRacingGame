using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Levelcomplete_panel;
    public GameObject LoadingPanel;
    public GameObject GameplayCar;
    public GameObject[] Cars;
    public GameObject[] Cams;
    public GameObject[] startpoint;
    public static GameManager instance;
    public GameObject lapactive1;
    public GameObject lapcomplete1;
    public GameObject lapactive2;
    public GameObject lapcomplete2;
    public GameObject lapactive3;
    public GameObject lapcomplete3;
    public int lapcompleted;
    public GameObject oneobjects;
    public GameObject twoobjects;
    public GameObject threeobjects;
    public int lapcounter;
    public Text laptext;
    public Text levelclearedtext;
    void Start()
    {
        instance = this;
        lapcompleted = 0;
        lapcounter = 1;
        laptext.text = "LAP " + lapcounter + " / 3";
        if (PlayerPrefs.GetInt("mode") == 0)
        {
            GameplayCar = Cars[Mainmenu.OnDisplayCar].gameObject;
            GameplayCar.SetActive(true);
            GameplayCar.transform.position = startpoint[0].transform.position;
            oneobjects.SetActive(true);
            twoobjects.SetActive(false);
            threeobjects.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("mode") == 1)
        {
           
            GameplayCar = Cars[Mainmenu.OnDisplayCar].gameObject;
            GameplayCar.SetActive(true);
            GameplayCar.transform.position = startpoint[1].transform.position;
            GameplayCar.transform.rotation = startpoint[1].transform.rotation;
            oneobjects.SetActive(false);
            twoobjects.SetActive(true);
            threeobjects.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("mode") == 2)
        {
            GameplayCar = Cars[Mainmenu.OnDisplayCar].gameObject;
            GameplayCar.SetActive(true);
            GameplayCar.transform.position = startpoint[2].transform.position;
            GameplayCar.transform.rotation = startpoint[2].transform.rotation;
            oneobjects.SetActive(false);
            twoobjects.SetActive(false);
            threeobjects.SetActive(true);
        }
        for (int i = 0; i < Cams.Length; i++)
        {
            Cams[i].SetActive(false);
        }
        Cams[Mainmenu.OnDisplayCar].SetActive(true);
    }
    public void Gameplay_Buttons(string btn_name)
    {
        if (btn_name == "restart")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (btn_name == "home")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void LevelClearedfn()
    {
        Levelcomplete_panel.SetActive(true);
        if (PlayerPrefs.GetInt("mode") == 0)
        {
            levelclearedtext.text = "Track 1 completed.";
        }
        else if (PlayerPrefs.GetInt("mode") == 1)
        {
            levelclearedtext.text = "Track 2 completed.";
        }
        else if (PlayerPrefs.GetInt("mode") == 2)
        {
            levelclearedtext.text = "Track 3 completed.";
        }
    }
    public void controlswithch()
    {
            RCC.SetMobileController(RCC_Settings.MobileController.Gyro);
            PlayerPrefs.SetString("Control", "tilt");
        
            RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
            PlayerPrefs.SetString("Control", "steering");
       
            RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
            PlayerPrefs.SetString("Control", "arrow");
        
    }
   
}
