using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip;
    public GameObject muteButton;
    public GameObject unmuteButton;
    public bool isMuted;
    public Sprite creditsImage;
    public Sprite muteButtonImage;
    public Sprite unmuteButtonImage;
    public int currentLevel;
    public GameObject creditsPanel;


    private void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    public void PlayGame()
    {
        if(currentLevel == 0) UnityEngine.SceneManagement.SceneManager.LoadScene("Fase Inicial 1");
        if(currentLevel == 1) UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");
    }

    public void MuteMusic()
    {
        if(isMuted == false)
        {
            isMuted = true;
            musicSource.Pause();
            muteButton.GetComponent<Image>().sprite = unmuteButtonImage;
        }
        else {
            isMuted = false;
            musicSource.Play();
            muteButton.GetComponent<Image>().sprite = muteButtonImage;
        }
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
        GetComponent<Image>().sprite = creditsImage;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeLanguage()
    {
        // Código para mudar o idioma
    }
    private void Update()
    {
        if (creditsPanel.activeSelf && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Escape)))
        {
            creditsPanel.SetActive(false);
        }
    }
}
