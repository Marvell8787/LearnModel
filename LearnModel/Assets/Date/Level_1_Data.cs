using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Level_1
{
    public static string[] Questions = new string[6] { "Goodbye", "Hi", "How are you", "Let's go", "Thank you", "You're welcome" };
    public static string[] Answer = new string[3] { "A","B","C" };
    public static int QuestionNum=1;
    public static int Right;
    public static int Wrong;
    public static void Refresh()
    {

        QuestionNum++;
        if (QuestionNum == 7) QuestionNum = 1;


    }

    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
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
