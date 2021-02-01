using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    Text timerText;
    public Text loseText;
    private bool gameOver;
    private bool restart;
    AudioSource audioSource;
    public AudioClip musicClipOne;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
        loseText.text = "";
        gameOver = false;
        restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = "Timer: " + Mathf.Round(timer);
        if (Input.GetKey(KeyCode.R))
        {
            if (gameOver == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
        if (timer >= 13)
        {
            gameOver = true;
            loseText.text = "You Lose! Press R to restart";
            musicSource.clip = musicClipOne;
            musicSource.Play();
        }
    }
}
