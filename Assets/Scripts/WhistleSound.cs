using UnityEngine;

public class WhistleSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayWhistleSound();
    }

    private void PlayWhistleSound()
    {
        audioSource.Play();
    }
}
