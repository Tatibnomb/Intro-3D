using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjectScript : MonoBehaviour
{
    public HealthManager healthManager;
    public ScoreManager scoreManager;
    public int damagePoints;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            if (healthManager != null)
            {
                healthManager.TakeDamage(damagePoints);
            }

            if (scoreManager != null)
            {
                scoreManager.AddScore(-damagePoints);
            }

            Destroy(gameObject);
        }
    }
}