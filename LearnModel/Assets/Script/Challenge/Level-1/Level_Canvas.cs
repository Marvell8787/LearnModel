﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Level_Canvas : MonoBehaviour {
    public static int Num = materials.Num;

    public static int[] RandomSequence = new int[Num];
    public static int[] RandomSequence_Ans = new int[6];
    public static string[] Data = new string[Num];
    // Use this for initialization
    void Start () {
        Random.seed = System.Guid.NewGuid().GetHashCode();

        RandomSequence = Level_1.GetRandomSequence(Num);
        Data =materials.materials_Data;
        for (int i = 0; i < 6; i++)
        {
            Data[i]= materials.materials_Data[i];
        }
        for (int i = 0; i < 6; i++)
        {
            int n = RandomSequence[i];
            Level_1.Questions[i] = Data[n];
        }

        Level_1.Refresh();

    }

    // Update is called once per frame
    void Update () {
		
	}


    public int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for(int i=0;i< total; i++)
        {
            output[i] = i;
        }
        for(int i=0;i< total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }

}
