using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUp : MonoBehaviour
{
    [SerializeField] private Image popUpImage;
    [SerializeField] private Text popUpText;
    [SerializeField] private float maxTime = 3f;
    [SerializeField] private float currentTime;
    [SerializeField] private bool isActive = true;


    public void Activate()
    {
        gameObject.SetActive(true);
        currentTime = maxTime;

    }

    private void Update()
    {
        if (currentTime < 0)
        {
            gameObject.SetActive(false);
        }
        if (isActive)
        {
            currentTime -= Time.deltaTime;
            Color color1 = popUpImage.color;
            Color color2 = popUpText.color;
            color1.a = currentTime / maxTime;
            color2.a = currentTime / maxTime;
            popUpText.color = color2;
            popUpImage.color = color1;
        }
    }
}
