using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{

    public int numOfHearts = 5;
    public int MaxHealth = 5;
    public int CurrentHealth = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject gameOverUI;
    public AudioClip deathClip;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    void Update()
    {

        if ( CurrentHealth > numOfHearts)
        {
            CurrentHealth = numOfHearts;
        }
        if (CurrentHealth == 0)
        {
            Time.timeScale = 0f;
            AudioSource.PlayClipAtPoint(deathClip, transform.position);
            gameOverUI.SetActive(true);
            CurrentHealth = 5;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < CurrentHealth)
            {

                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentHealth = MaxHealth;
            Time.timeScale = 1f;
        }

        if (CurrentHealth == -1)
        {
            CurrentHealth = 0;
        }

        //if (CurrentHealth == 0)
        //{
          //  Time.timeScale = 0f;
           // gameOverUI.SetActive(true);
        //}


    }

    void GetDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;
    }


}

//Made by Mikołaj Sieradzki 3E