using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAfterTournament : MonoBehaviour
{
    //public delegate void Unlock(int a);
    //public static event Unlock Unlocks;

    [SerializeField] private GameObject[] t1;
    [SerializeField] private GameObject[] t2;
    [SerializeField] private GameObject[] t3;

    public void Unlock(int a)
    {
        if (a == 1)
        {
            for(int i=0;i<t1.Length;i++)
            {
                t1[i].SetActive(false);
            }
        }
        if (a == 2)
        {
            for (int i = 0; i < t2.Length; i++)
            {
                t2[i].SetActive(false);
            }
        }
        if (a == 3)
        {
            for (int i = 0; i < t3.Length; i++)
            {
                t3[i].SetActive(false);
            }
        }
    }
}
