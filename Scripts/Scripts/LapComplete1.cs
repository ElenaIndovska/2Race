using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LapComplete1 : MonoBehaviour
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
        if (LapTimeManager1.SecCount <= 9)
        {
            SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager1.SecCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<Text>().text = "" + LapTimeManager1.SecCount + ".";
        }

        if (LapTimeManager1.MinCount <= 9)
        {
            MinDisplay.GetComponent<Text>().text = "0" + LapTimeManager1.MinCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<Text>().text = "" + LapTimeManager1.MinCount + ".";
        }

        
        MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager1.MiliCount;

        PlayerPrefs.SetInt("MinSave", LapTimeManager1.MinCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager1.SecCount);
        PlayerPrefs.SetFloat("MiliSave", LapTimeManager1.MiliCount);

        LapTimeManager1.MinCount = 0;
        LapTimeManager1.SecCount = 0;
        LapTimeManager1.MiliCount = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

        if (LapsDone == 1)
        {
            SceneManager.LoadScene(7);
            
        }
    }

}
