using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    void OnTriggerEnter()
    {
        LapsDone += 1;
        if (LapTimeManager.SecCount <= 9)
        {
            SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecCount + ".";
        }

        if (LapTimeManager.MinCount <= 9)
        {
            MinDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinCount + ".";
        }

        
        MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;

        PlayerPrefs.SetInt("MinSave", LapTimeManager.MinCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.SecCount);
        PlayerPrefs.SetFloat("MiliSave", LapTimeManager.MiliCount);

        LapTimeManager.MinCount = 0;
        LapTimeManager.SecCount = 0;
        LapTimeManager.MiliCount = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

        

        if (LapsDone == 1)
        {
            SceneManager.LoadScene(6);
            
        }
    }

}
