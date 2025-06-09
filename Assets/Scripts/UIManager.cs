using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHp;
    public MoneyManager moneyManager;
    public HealthManager healthManager;

    private void Start()
    {
        txtMoney.text = "$" + moneyManager.money.ToString();
        txtHp.text = "HP " + healthManager.health.ToString();

    }
    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
    public void UpdateHpText(string health)
    {
        txtHp.text = "HP " +  health;
    }
}
