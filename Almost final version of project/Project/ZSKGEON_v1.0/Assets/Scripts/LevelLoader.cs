using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public void PlayGame(int sceneIndex)
    {
        //This allows us to click button and move to next scene
        mainmenu.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadAsync(sceneIndex));
        

    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progress = (float)System.Math.Round(progress, 1);
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }
}
