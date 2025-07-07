using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;
    public ScoreManager scoreManager;

    private void Start()
    {
        UIInteractionMessage.SetActive(false);
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract && mercaderia != null)
        {
            DamageObjectScript damage = mercaderia.GetComponent<DamageObjectScript>();

            if (damage != null)
            {
                if (damage.healthManager != null)
                    damage.healthManager.TakeDamage(damage.damagePoints);

                if (scoreManager != null)
                    scoreManager.AddScore(-damage.damagePoints);
            }
            else
            {
                if (scoreManager != null)
                    scoreManager.AddScore(mercaderia.scorePoints);
            }

            Destroy(mercaderia.gameObject);
            EndInteraction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        EndInteraction();
    }

    void EndInteraction()
    {
        mercaderia = null;
        canInteract = false;
        UIInteractionMessage.SetActive(false);
    }

}
