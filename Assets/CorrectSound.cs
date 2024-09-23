using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectSound : MonoBehaviour
{
    public string targetTag = "Player";  // Tag of the correct object
    public AudioClip correctSoundClip;   // Sound for the correct object
    public AudioClip wrongSoundClip;     // Sound for the wrong object

    public Material materialGreen, materialRed, materialDefault;
    public MeshRenderer meshRenderer;

    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // This method is called when another object enters the trigger collider
    void OnTriggerEnter(Collider other)
    {
        // If the object has the correct tag, play the correct sound
        if (other.CompareTag(targetTag))
        {
            PlaySound(correctSoundClip);
            meshRenderer.material = materialGreen;
        }
        // If the object has the wrong tag, play the wrong sound
       //else
       // {
        //  PlaySound(wrongSoundClip);
        //   meshRenderer.material = materialRed;
     // }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
           
            meshRenderer.material = materialGreen;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        meshRenderer.material = materialDefault;
    }
   
    // Helper method to play a sound
    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}
