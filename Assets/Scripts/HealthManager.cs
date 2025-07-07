using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int HealthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        HealthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if (HealthPoints <= damagePoints)
        {
            // Game over
            HealthPoints = 0;
            return;
        }
        HealthPoints -= damagePoints;
        uiManager.UpdateHealth(HealthPoints);
        Debug.Log("Damage");
    }
}