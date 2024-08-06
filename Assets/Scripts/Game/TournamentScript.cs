using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TournamentScript : MonoBehaviour
{
    [SerializeField] private GameObject donedText;
    [SerializeField] private int maxStageCount;
    [SerializeField] private int currentStageCount;
    [SerializeField] private Text currentStageCounttxt;
    [SerializeField] private int[] teamsPowers;
    [SerializeField] private Text currentTeamPowers;
    [SerializeField] private MainGameScript stats;
    [SerializeField] private Button button;


    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject deniedPanel;
    [SerializeField] private int money;
    [SerializeField] private int coins;
    [SerializeField] private bool last;

    private void Start()
    {
        currentStageCounttxt.text= (currentStageCount+1).ToString();
        currentTeamPowers.text = (teamsPowers[currentStageCount]+1).ToString();
    }
    public void DonedTextUp()
    {
        donedText.SetActive(true) ;
    }

    public void GoFight()
    {
        if(currentStageCount+1< maxStageCount)
        {
            if (teamsPowers[currentStageCount] < stats.teamPower)
            {
                currentStageCount += 1;
                currentTeamPowers.text = teamsPowers[currentStageCount].ToString();
                currentStageCounttxt.text = (currentStageCount + 1).ToString();
            }
        }
        else
        {
            DonedTextUp();
            button.interactable = false;
            winPanel.SetActive(true);
        }
    }

    public void EndTournament()
    {

        stats.money += money;
        coins += Saver.GetMoney();
        Saver.SetMoney(coins);
        winPanel.SetActive(false);
        deniedPanel.SetActive(false);
    }
}
