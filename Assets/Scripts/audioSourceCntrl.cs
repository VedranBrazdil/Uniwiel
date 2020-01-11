using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSourceCntrl : MonoBehaviour
{

    public AudioClip[] songs;
    public AudioSource songSource;


    // Use this for initialization
    void Start()
    {
        songSource.clip = songs[0];
        songSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void PlaySong(int x)
    {
        songSource.Pause();
        songSource.clip = songs[x];
        //songSource.volume = 0;
        //fadeIn();
        songSource.Play();

    }

    public void fadeIn()
    {
        float t = 0.0f;
        while (t < 0.4f)
        {
            t += (Time.deltaTime);
            songSource.volume = t;

        }
    }
}
