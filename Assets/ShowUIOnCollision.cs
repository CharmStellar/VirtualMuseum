using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIOnCollision : MonoBehaviour
{
    // Reference to the UI element you want to show/hide
    public GameObject uiElement;

    // Called when something enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger collider
        if (other.CompareTag("Player"))
        {
            // Enable the UI element when the player enters the collision box
            uiElement.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Enable the UI element when the player enters the collision box
            uiElement.SetActive(true);
        }
    }
    // Called when something exits the trigger collider
    private void OnTriggerExit(Collider other)
    {
        // Check if the player exited the trigger collider
        if (other.CompareTag("Player"))
        {
            // Disable the UI element when the player exits the collision box
            uiElement.SetActive(false);
        }
    }
}
