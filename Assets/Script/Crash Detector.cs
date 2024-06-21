using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]  ParticleSystem finishEffect;
    [SerializeField]  AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScence",0.5f);
         
        }

      

        
    }
    void ReloadScence()
    {
        Debug.Log("Ooop! one hit");
        SceneManager.LoadScene(0);
    }
}
