﻿using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsManager : MonoBehaviour
{
    public List<GameObject> AllPlants = new List<GameObject>();
    public List<PlantForContractOne> FirstPlantsForContract = new List<PlantForContractOne>();
    public List<PlantForContractTwo> SecondPlantsForContract = new List<PlantForContractTwo>();
    public List<PlantForContractThree> ThirdPlantsForContract = new List<PlantForContractThree>();
    public List<PlantForContractFour> FourthPlantsForContract = new List<PlantForContractFour>();
    public List<PlantForContractFive> FifthPlantsForContract = new List<PlantForContractFive>();
    public static PlantsManager PlantsManagerInstance;

    void Awake()
    {
        PlantsManagerInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(DATABASEURL);
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        //for (int i = 0; i < Plants.Count; i++)
        //{
        //    Plants[i].id = i;
        //}
        for (int i = 0; i < FirstPlantsForContract.Count; i++)
        {
            FirstPlantsForContract[i].id = i;
        }
        for (int i = 0; i < SecondPlantsForContract.Count; i++)
        {
            SecondPlantsForContract[i].id = i;
        }
        for (int i = 0; i < ThirdPlantsForContract.Count; i++)
        {
            ThirdPlantsForContract[i].id = i;
        }
        for (int i = 0; i < FourthPlantsForContract.Count; i++)
        {
            FourthPlantsForContract[i].id = i;
        }
        for (int i = 0; i < FifthPlantsForContract.Count; i++)
        {
            FifthPlantsForContract[i].id = i;
        }
    }

    public void SetValueForFirstPlantsForContract(ContractInfo contract)
    {
        // StartCoroutine(AttachPlantsToContractAfterContractIsCreated(contract.ContractID));

    }

    IEnumerator AttachPlantsToContractAfterContractIsCreated(int contract)
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < FirstPlantsForContract.Count; i++)
        {
            FirstPlantsForContract[i].plant.ContractID = contract;
            FirstPlantsForContract[i].plant.isPlantInContract = true;
        }
    }



    public void IncrementGrowthDaysForEachPlans()
    {
        for (int i = 0; i < FirstPlantsForContract.Count; i++)
        {
            if (FirstPlantsForContract[i].plant != null)//.isDroneAssigned)
            {
                //increment days
                int growthDayIncrementer = FirstPlantsForContract[0].plant.GrowthDays;

                Dictionary<string, object> lParameters = new Dictionary<string, object>();

                SinglePlant plant = new SinglePlant();

                lParameters.Add("GrowthDays", plant.GrowthDays = growthDayIncrementer += 1);
                lParameters.Add("isDroneAssigned", plant.isDroneAssigned = true);
                //    PlayerPrefs.SetInt("frPlants", plant.GrowthDays);
                reference.Child("USERS").Child(LogInAndRegister.Instance.UserName).Child("GAMESPACE").Child("CONTRACT" + 0).Child("PLANTS").Child("PLANT" + i).UpdateChildrenAsync(lParameters);
            }
        }

        for (int i = 0; i < SecondPlantsForContract.Count; i++)
        {

            if (SecondPlantsForContract[i].plant != null)//.isDroneAssigned)
            {
                //increment days
                int growthDayIncrementer = SecondPlantsForContract[0].plant.GrowthDays;

                Dictionary<string, object> lParameters = new Dictionary<string, object>();

                SinglePlant plant = new SinglePlant();

                lParameters.Add("GrowthDays", plant.GrowthDays = growthDayIncrementer += 1);
                lParameters.Add("isDroneAssigned", plant.isDroneAssigned = true);
                //    PlayerPrefs.SetInt("frPlants", plant.GrowthDays);
                reference.Child("USERS").Child(LogInAndRegister.Instance.UserName).Child("GAMESPACE").Child("CONTRACT" + 1).Child("PLANTS").Child("PLANT" + i).UpdateChildrenAsync(lParameters);
            }
        }

            //}
            //for (int i = 0; i < ThirdPlantsForContract.Count; i++)
            //{

            //        if (ThirdPlantsForContract[i].plant.isDroneAssigned)
            //        {
            //            //increment days
            //            int growthDayIncrementer = ThirdPlantsForContract[0].plant.GrowthDays;

            //            Dictionary<string, object> lParameters = new Dictionary<string, object>();

            //            SinglePlant plant = new SinglePlant();

            //            lParameters.Add("GrowthDays", plant.GrowthDays = growthDayIncrementer += 1);
            //            lParameters.Add("isDroneAssigned", plant.isDroneAssigned = true);
            //            //    PlayerPrefs.SetInt("frPlants", plant.GrowthDays);
            //            reference.Child("USERS").Child(LogInAndRegister.Instance.UserName).Child("GAMESPACE").Child("CONTRACT" +2).Child("PLANTS").Child("PLANT" + i).UpdateChildrenAsync(lParameters);
            //        }


            //}

            //for (int i = 0; i < FourthPlantsForContract.Count; i++)
            //{

            //    if (FourthPlantsForContract[i].plant.isDroneAssigned)
            //    {
            //        //increment days
            //        int growthDayIncrementer = FourthPlantsForContract[0].plant.GrowthDays;

            //        Dictionary<string, object> lParameters = new Dictionary<string, object>();

            //        SinglePlant plant = new SinglePlant();

            //        lParameters.Add("GrowthDays", plant.GrowthDays = growthDayIncrementer += 1);
            //        lParameters.Add("isDroneAssigned", plant.isDroneAssigned = true);
            //        //    PlayerPrefs.SetInt("frPlants", plant.GrowthDays);
            //        reference.Child("USERS").Child(LogInAndRegister.Instance.UserName).Child("GAMESPACE").Child("CONTRACT" + 3).Child("PLANTS").Child("PLANT" + i).UpdateChildrenAsync(lParameters);
            //    }

            //}
            //for (int i = 0; i < FifthPlantsForContract.Count; i++)
            //{

            //    if (FifthPlantsForContract[i].plant.isDroneAssigned)
            //    {
            //        //increment days
            //        int growthDayIncrementer = FifthPlantsForContract[0].plant.GrowthDays;

            //        Dictionary<string, object> lParameters = new Dictionary<string, object>();

            //        SinglePlant plant = new SinglePlant();

            //        lParameters.Add("GrowthDays", plant.GrowthDays = growthDayIncrementer += 1);
            //        lParameters.Add("isDroneAssigned", plant.isDroneAssigned = true);
            //        //    PlayerPrefs.SetInt("frPlants", plant.GrowthDays);
            //        reference.Child("USERS").Child(LogInAndRegister.Instance.UserName).Child("GAMESPACE").Child("CONTRACT" +4).Child("PLANTS").Child("PLANT" + i).UpdateChildrenAsync(lParameters);
            //    }
            //}

        }

    public void CallPlantsPlanting(int plantListNumber)
    {

        if (plantListNumber == 0)
        {
            for (int i = 0; i < FirstPlantsForContract.Count; i++)
            {
                FirstPlantsForContract[i].SetEachPlantDataInDbAfterCreatingContract();
            }
        }

        if (plantListNumber == 1)
        {
            for (int i = 0; i < SecondPlantsForContract.Count; i++)
            {
                SecondPlantsForContract[i].SetEachPlantDataInDbAfterCreatingContract();
            }
        }

        if (plantListNumber == 2)
        {
            for (int i = 0; i < ThirdPlantsForContract.Count; i++)
            {
                ThirdPlantsForContract[i].SetEachPlantDataInDbAfterCreatingContract();
            }
        }

        if (plantListNumber == 3)
        {
            for (int i = 0; i < FourthPlantsForContract.Count; i++)
            {
                FourthPlantsForContract[i].SetEachPlantDataInDbAfterCreatingContract();
            }
        }

        if (plantListNumber == 4)
        {
            for (int i = 0; i < FifthPlantsForContract.Count; i++)
            {
                FifthPlantsForContract[i].SetEachPlantDataInDbAfterCreatingContract();
            }
        }

    }

    public void Test()
    {
        for (int i = 0; i < FirstPlantsForContract.Count; i++)
        {
            FirstPlantsForContract[i].GetDBDataForPlant();

        }
        for (int i = 0; i < SecondPlantsForContract.Count; i++)
        {
            SecondPlantsForContract[i].GetDBDataForPlant();

        }
        for (int i = 0; i < ThirdPlantsForContract.Count; i++)
        {
            ThirdPlantsForContract[i].GetDBDataForPlant();

        }
        for (int i = 0; i < FourthPlantsForContract.Count; i++)
        {
            FourthPlantsForContract[i].GetDBDataForPlant();


        }
        for (int i = 0; i < FifthPlantsForContract.Count; i++)
        {
            FifthPlantsForContract[i].GetDBDataForPlant();

        }
    }

    // Update is called once per frame
    void Update()
    {

    }






    DatabaseReference reference;
    string DATABASEURL = "https://purriadb.firebaseio.com/";


    [Serializable]
    public class SinglePlant
    {
        public bool isDroneAssigned;
        public bool isPlantPlanted;
        public bool isPlantInContract;
        public int FieldID;
        public int ContractID;
        public int GrowthDays;
    }
}
