using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameScript : MonoBehaviour
{
    [SerializeField] private Text teamPowerText;
    [SerializeField] private Text moneyText;
    [SerializeField] private Text passiveIncomeText;

    public float teamPower;
    public float money;

    public float currentPrice;
    public float currentRandom;

    public int passiveIncome;
    private float coef;
    void Start()
    {
        coef = Saver.GetCoef() + 1f;
        UpdateStats();
    }

    void UpdateStats()
    {
        passiveIncomeText.text = "+"+passiveIncome.ToString()+" /sec";
        teamPowerText.text = ((int)teamPower).ToString();
        moneyText.text = ((int)money).ToString();
    }

    void Update()
    {
        money += passiveIncome * Time.deltaTime*coef;
        UpdateStats();
    }

    public void AddMoney(float gmoney)
    {
        money += gmoney+currentRandom;
        currentRandom = 0;
        UpdateStats();
    }

    public void SellingMerch()
    {
        money += (int)(teamPower / 100 * Random.Range(1, 3));
        currentRandom = 0;
        UpdateStats();
    }

    public void AddPassiveIncome(int gmoney)
    {
        if (currentPrice <= money)
        {
            passiveIncome += gmoney;
        }
        currentPrice = 0f;
        UpdateStats();
    }

    public void AddTeamPower(float tp)
    {
        if(currentPrice<=money)
        {
            money -= currentPrice;
            teamPower += tp;
            UpdateStats();
        }
        currentPrice = 0f;
    }

    public void AddTeamPowerRandom()
    {
        if (currentPrice <= money)
        {
            money -= currentPrice;
            teamPower += Random.Range(20,50);
            UpdateStats();
        }
        currentPrice = 0f;
    }
    public void SetCurrentPrice(float cp)
    {
        currentPrice = cp;
    }
    public void SetCurrentRandomRange(float range)
    {
        currentRandom = Random.Range(0,range);
    }


    public void AddTeamPowerPercent(float tp)
    {
        teamPower *= (1+tp/100);
        UpdateStats();
    }
}
