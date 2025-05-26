using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore();

        }
        
    }
}
