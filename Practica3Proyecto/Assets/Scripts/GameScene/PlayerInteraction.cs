using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float InteractionDistance = 2f;
    public LayerMask InteractionMask;
    public Transform PlayerCam;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForInteraction();
        }
    }

    public void CheckForInteraction()
    {
        RaycastHit ray;
        if (Physics.Raycast(PlayerCam.position, PlayerCam.forward, out ray, InteractionDistance, InteractionMask))
        {
            InteractableObject interactableObject = ray.collider.GetComponent<InteractableObject>();
            if (interactableObject != null)
            {
                interactableObject.Interact();
            }
        }
    }
}