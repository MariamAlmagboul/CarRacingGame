using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScript : MonoBehaviour
{ 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lapactive1")
        {
            GameManager.instance.lapcomplete1.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "lapcomplete1")
        {
            GameManager.instance.lapcounter++;
            GameManager.instance.laptext.text = "LAP " + GameManager.instance.lapcounter + " / 3";
            GameManager.instance.lapcompleted++;
            if (GameManager.instance.lapcompleted >= 3)
            {
                GameManager.instance.LevelClearedfn();
            }
            else
            {
                GameManager.instance.lapactive1.SetActive(true);
            }
        }
        if (other.gameObject.tag == "lapactive2")
        {
            GameManager.instance.lapcounter++;
            GameManager.instance.laptext.text = "LAP " + GameManager.instance.lapcounter + " / 3";
            GameManager.instance.lapcomplete2.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "lapcomplete2")
        {
            GameManager.instance.lapcompleted++;
            if (GameManager.instance.lapcompleted >= 3)
            {
                GameManager.instance.LevelClearedfn();
            }
            else
            {
                GameManager.instance.lapactive2.SetActive(true);
            }
        }
        if (other.gameObject.tag == "lapactive3")
        {
            GameManager.instance.lapcomplete3.SetActive(true);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "lapcomplete3")
        {
            GameManager.instance.lapcounter++;
            GameManager.instance.laptext.text = "LAP " + GameManager.instance.lapcounter + " / 3";
            GameManager.instance.lapcompleted++;
            if (GameManager.instance.lapcompleted >= 3)
            {
                GameManager.instance.LevelClearedfn();
            }
            else
            {
                GameManager.instance.lapactive3.SetActive(true);
            }
        }
    }
    }
