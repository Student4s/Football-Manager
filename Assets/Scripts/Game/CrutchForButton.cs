using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using Unity.VisualScripting;
using UnityEngine;

public class CrutchForButton : MonoBehaviour
{
    public ButtonCooldown button;

    private void Update()
    {
        if (button.buttonPrice <= button.stats.money && !button.cooldown)
        {
            button.button.interactable = true;
        }
        else
        {
            button.button.interactable = false;
        }
    }
}
