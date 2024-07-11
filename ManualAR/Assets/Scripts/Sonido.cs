using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource audiosource;

    public void PlaySoundEffect()
    {
        if (audiosource != null)
        {
            audiosource.Play();
        }
    }
}
