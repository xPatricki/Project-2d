using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void playAgain()
    {
       SceneManager.LoadScene(1);

    }
    public void QuitToMainMenu()
    {
       SceneManager.LoadScene(0);
    }
}
