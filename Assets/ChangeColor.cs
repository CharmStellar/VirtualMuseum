using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material materialGreen, materialRed;
    public MeshRenderer meshRenderer;
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
        audioSource.Play();
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay");
        meshRenderer.material = materialGreen;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
        meshRenderer.material = materialRed;
    }
}
