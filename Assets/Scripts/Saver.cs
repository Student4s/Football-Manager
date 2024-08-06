using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Saver : MonoBehaviour
{
    [SerializeField] private const string isSound = "isSound";
    [SerializeField] private const string money = "money";
    [SerializeField] private const string coef = "coef";
    [SerializeField] private const string altMusicBuyed = "altMusicBuyed";
    [SerializeField] private const string altMusicUsing = "altMusicUsing";

    public static void SetSound(int A)
    {
        PlayerPrefs.SetInt(isSound, A);
    }
    public static int GetSound()
    {
        return PlayerPrefs.GetInt(isSound);
    }
    public static void SetMoney(int A)
    {
        PlayerPrefs.SetInt(money, A);
    }
    public static int GetMoney()
    {
        return PlayerPrefs.GetInt(money);
    }
    public static void SetCoef(float A)
    {
        PlayerPrefs.SetFloat(coef, A);
    }
    public static float GetCoef()
    {
        return PlayerPrefs.GetFloat(coef);
    }
    public static void SetAlt(int A)
    {
        PlayerPrefs.SetInt(altMusicBuyed, A);
    }
    public static float GetAlt()
    {
        return PlayerPrefs.GetInt(altMusicBuyed);
    }
    public static void SetAltUse(int A)
    {
        PlayerPrefs.SetInt(altMusicUsing, A);
    }
    public static float GetAltUse()
    {
        return PlayerPrefs.GetInt(altMusicUsing);
    }
}
