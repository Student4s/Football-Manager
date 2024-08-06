using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    public Image circleImage;
    public Button button;
    public float duration = 3f;

    public float buttonPrice;
    public MainGameScript stats;

    private float elapsedTime = 0f;
    public bool cooldown = false;


    void Update()
    {
        if (elapsedTime < duration && cooldown==true)
        {
            elapsedTime += Time.deltaTime;
            float fillAmount = Mathf.Clamp01(1 - (elapsedTime / duration));
            circleImage.fillAmount = fillAmount;
        }
        else
        {
            circleImage.fillAmount = 1f;
            elapsedTime = 0f;
            gameObject.SetActive(false);
            cooldown = false;
        }
    }

    public void StartCoolDown()
    {
        if (buttonPrice <= stats.money && !cooldown)
        {
            button.interactable = false;
            cooldown = true;
            gameObject.SetActive(true);
        }
    }
}
