using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOneUse : MonoBehaviour
{
    public float buttonPrice;
    public MainGameScript stats;
    public Button button;
    public GameObject Buyed;



    public void TryToUse()
    {
        if (buttonPrice <= stats.money)
        {
            Buyed.SetActive(true);
            button.interactable = false;
        }
    }

}
