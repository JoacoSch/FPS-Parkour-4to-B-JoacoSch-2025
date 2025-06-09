using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }
    public bool UpdateHp(float amount)
    {
        if (health + amount <= 0)
        {
            return false;
        }
        else
        {
            health += amount;
            uiManager.UpdateHpText(health.ToString());
            return true;
        }

    }
}
