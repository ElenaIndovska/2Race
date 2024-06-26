using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MiliCount;
    public static string MiliDisplay;

    public GameObject MinBox;
    public GameObject SecBox;
    public GameObject MiliBox;

    // Update is called once per frame
    void Update()
    {
        MiliCount += Time.deltaTime * 10;
        MiliDisplay = MiliCount.ToString("F0");
        MiliBox.GetComponent<Text>().text = "" + MiliDisplay;
        
        if(MiliCount >= 10)
        {
            MiliCount = 0;
            SecCount += 1;
        }

        if(SecCount <= 9)
        {
            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecBox.GetComponent<Text>().text = "" + SecCount + ".";
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if (MinCount <= 9)
        {
            MinBox.GetComponent<Text>().text = "0" + MinCount + ".";
        }
        else
        {
            MinBox.GetComponent<Text>().text = "" + MinCount + ".";
        }

    }
}
