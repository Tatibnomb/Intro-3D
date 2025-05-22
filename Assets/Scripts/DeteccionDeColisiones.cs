using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
