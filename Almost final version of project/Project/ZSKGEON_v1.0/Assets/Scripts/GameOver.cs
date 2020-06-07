using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public int SceneToLoad;

        public void restartLevel()
        {
             SceneManager.LoadScene(SceneToLoad);
            gameOverUI.SetActive(false);
            Time.timeScale = 1f;
    }

        public void QuitGame()
        {
            Application.Quit();
            Debug.Log("QUIT!");
        }
        public void BackToMenu()
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Menu!");
        }
}
