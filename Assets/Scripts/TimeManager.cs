using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public int canCount; //1 = true 0 = false 
    public float TimePassed; // in seconds
    public static TimeManager Instance;


    void Awake()
    {
        Instance = this;
        TimePassed = PlayerPrefs.GetFloat("TimePassed");
    }

    void Stat()
    {
        canCount = 0;

    }



    void Update()
    {

        if (canCount == 1)
        {
            TimePassed += Time.deltaTime;

            if (TimePassed > 10) //86400)
            {
                // reset time to 0 and save it
                Debug.Log("day has passed");
                TimePassed = 0;
                canCount = 0;
                PlantsManager.PlantsManagerInstance.IncrementGrowthDaysForEachPlans();


            }

        }

    }


    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("TimePassed", TimePassed);
    }


}
