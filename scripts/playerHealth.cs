using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {
    public int startingHealth ;
    public int currentHealth ;
    public Slider healthSlider;
    public float flashSpeed;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Image damageImage;

    bool damaged;

    void Start()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }

        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

        }
        damaged = false;

    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
