using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;

    private void Start()
    {
        UIInteractionMessage.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract && mercaderia != null)
            {
                Destroy(mercaderia.gameObject);
                EndInteraction();
            }
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
