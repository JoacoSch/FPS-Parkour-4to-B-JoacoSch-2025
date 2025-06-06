using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public TextMeshProUGUI txtMoney;
    public MoneyManager moneyManager;

    private void Start()
    {
        txtMoney.text = "$" + moneyManager.money.ToString();
    }
    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
}
