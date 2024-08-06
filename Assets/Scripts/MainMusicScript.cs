using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusicScript : MonoBehaviour
{
    public AudioSource audios;
    public GameObject button;

    public AudioClip audio1;
    public AudioClip audio2;

    public GameObject altMusic;
    public bool isAlt;
    public GameObject button2;

    private void Start()
    {
        if(Saver.GetAltUse()==1)
        {
            audios.clip = audio2;
            audios.Play();
        }
        else
        {
            audios.clip = audio1;
            audios.Play();
        }
        int A = Saver.GetSound();
        if(A==1)
        {
            audios.volume = 0.05f;
            button.SetActive(true);
        }
        else
        {
            audios.volume = 0f;
            button.SetActive(false);
        }

        if(Saver.GetAlt()==1)
        {
            altMusic.SetActive(true);
        }
    }

    public void ChangeSound()
    {
        if(audios.volume == 0f)
        {
            audios.volume = 0.05f;
            Saver.SetSound(1);
            button.SetActive(true);
        }
        else
        {
            audios.volume = 0f;
            Saver.SetSound(0);
            button.SetActive(false);
        }
    }
    public void ChangeAlt()
    {
        if (audios.clip == audio1)
        {
            audios.clip = audio2;
            Saver.SetAltUse(1);
            button2.SetActive(true);
            audios.Play();
        }
        else
        {
            audios.clip = audio1;
            Saver.SetAltUse(0);
            button2.SetActive(false);
            audios.Play();
        }
    }
}
