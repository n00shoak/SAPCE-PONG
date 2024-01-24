using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    public AudioClip[] musics;
    AudioSource source;
    public int index;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(index-1 > musics.Length)
        {
            index = 0;
        }

        if(!source.isPlaying) {
            source.clip = musics[index];
            source.Play();
            index++;
        }
    }
}
