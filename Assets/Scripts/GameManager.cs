using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour {

    int score;
    public int life;
    public Image[] lifeIcon;
    public static GameManager inst;

    public AudioClip coinCollect, coneDash;
    public AudioSource audioPlayer;

    [SerializeField] TMP_Text scoreText;

    [SerializeField] PlayerController PlayerController;
    public LevelController levelController;

    public void IncrementScore ()
    {
        audioPlayer.clip = coinCollect;
        audioPlayer.Play();
        score++;
        scoreText.text =  score.ToString();
    }
    public void Update()
    {
        if (score >= 100)
        {
            //You won load next level
            PlayerController.winingPage.gameObject.SetActive(true);
            Time.timeScale = 0;
            PlayerPrefs.SetInt("level", levelController.levelUnlock);
            //AudioListener.volume = 0;
        }
    }
    public void DecreaseLife()
    {
        lifeIcon[life].color = Color.white;
        audioPlayer.clip = coneDash;
        audioPlayer.Play();
        life--;
    }

    private void Awake ()
    {
        inst = this;
        life = 2;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}