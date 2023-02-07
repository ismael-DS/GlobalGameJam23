using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrilhaTutorial : MonoBehaviour
{

    public GameObject panel;
    public AudioSource audioSource; 
    public AudioClip[] tracks;
    public float time = 90f;
    private int currentTrack = 0;

    private void Start()
    {
        audioSource.clip = tracks[currentTrack];
        audioSource.Play();
        Invoke("ChangeTrack", time);   

        panel.SetActive(false);
        Invoke("ShowPanel", time);
    }

    private void ChangeTrack()
    {
        currentTrack++; 
        if (currentTrack >= tracks.Length)
        {
            currentTrack = 0;
        }
        audioSource.Stop(); // 
        audioSource.clip = tracks[currentTrack]; // 
        audioSource.Play(); 
    }

    private void ShowPanel()
    {
        panel.SetActive(true);
    }
}
