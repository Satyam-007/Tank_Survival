using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public int damage=25;
    GameObject bullet;
    public int scoreValue = 10;
    playerHealth hp;
    GameObject player;

    BoxCollider boxCollider;
    bool isDead;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boxCollider = GetComponent<BoxCollider>();
        currentHealth = startingHealth;
        bullet = GameObject.FindGameObjectWithTag("shot");
        hp = player.GetComponent<playerHealth>(); 
    }

    void Death()
    {
        isDead = true;
        boxCollider.isTrigger = true;
        gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        
            if (isDead)
                return;

            currentHealth -= damage;
            scoremanager.score += scoreValue;

            if (currentHealth <= 0)
            {
                Death();
            }
    }

    private void Update()
    {
        if(hp.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
