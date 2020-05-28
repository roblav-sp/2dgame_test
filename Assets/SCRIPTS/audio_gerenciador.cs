using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_gerenciador : MonoBehaviour
{
    public AudioSource sons;
    public static audio_gerenciador inst = null;

    void Awake()
    {
        if(inst==null)
        {
            inst = this;

        }
        else if(inst !=null)
        {
            Destroy(gameObject);
        }

    }
    public void PlayAudio(AudioClip clipaudio)
    {
        sons.clip = clipaudio;
        sons.Play();
    }
}
