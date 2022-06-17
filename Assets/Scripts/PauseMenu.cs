using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameScore;
    [SerializeField] GameObject gameHighScore;
    [SerializeField] GameObject pauseBtn;
    [SerializeField] GameObject joyStick;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameScore.SetActive(false);
        gameHighScore.SetActive(false);
        pauseBtn.SetActive(false);
        joyStick.SetActive(false);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameScore.SetActive(true);
        gameHighScore.SetActive(true);
        pauseBtn.SetActive(true);
        joyStick.SetActive(true);
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
