using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Text moneyCount;

    public int money;
    public PopUp pop;
    void Start()
    {
       if(Saver.GetMoney()==null)
        {
            money = 0;
        }
       else
        {
            money = Saver.GetMoney();
        }
       UpdateScores();
    }

public void Buy(int price)
    {
        if (Saver.GetAlt()!=1)
        {
            if (money >= price)
            {
                money -= price;
                Saver.SetMoney(money);
            }
            else
            {
                pop.Activate();
            }
        }
       
    }

    void UpdateScores()
    {
        moneyCount.text = money.ToString();
    }
}
