using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiSoundsRandom : MonoBehaviour
{

    [SerializeField] private AudioClip[] tableSounds;
    private AudioSource audioSource;

    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
	}

    public void PlaySound()
    {
        int indexSoundRandom = Random.Range(0, tableSounds.Length);
        audioSource.clip = tableSounds[indexSoundRandom];
        audioSource.Play();
    }
}

