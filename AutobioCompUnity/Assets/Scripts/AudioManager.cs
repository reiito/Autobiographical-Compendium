using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip introduction;
    public AudioClip playstation;
    public AudioClip door;

    AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayIntroSound()
    {
        audioSource.clip = introduction;
        audioSource.Play();
    }

    public void PlayPSSound()
    {
        audioSource.clip = playstation;
        audioSource.Play();
    }

    public void PlayDoorSound()
    {
        audioSource.clip = door;
        audioSource.Play();
    }
}
