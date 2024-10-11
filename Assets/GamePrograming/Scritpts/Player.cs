using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int health = 0;
    public Text text;
    public GameObject canvas;
    public Slider slider;

    private void Start()
    {
        health = maxHealth;
        text.text = health.ToString() + "%";
        slider.value = health;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        text.text = health.ToString() + "%";
        if (health <= 0)
        {
            Die();
        }
        slider.value = health;

        
    }

    void Die()
    {
        canvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }
}
