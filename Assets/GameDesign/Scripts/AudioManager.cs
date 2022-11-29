using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource src;
    public List<AudioClip> soundList = new List<AudioClip>();
  
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    public void PlaySound(string clipName)
    {
        foreach(AudioClip audioClip in soundList)
        {
            if (audioClip.name == clipName)
            {
                src.PlayOneShot(audioClip);
                break;
            }
        }
    }

}
