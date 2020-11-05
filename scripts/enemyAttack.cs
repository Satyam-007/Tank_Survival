using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 10.0f;
    public int attackDamage = 5;
    Animator anim;
    GameObject player;
    bool playerInRange;
    float timer;
    playerHealth hp;
    enemyHealth ehealth;
   

	void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        hp = player.GetComponent<playerHealth>();
        ehealth = GetComponent<enemyHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
            anim.SetTrigger("attack2");
        }
    }
    void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && ehealth.currentHealth > 0)
        {
            Attacks();
            timer = 0.0f;
        }
	}

    void Attacks()
    {
        if (hp.currentHealth > 0)
        {
            hp.TakeDamage(attackDamage);
            anim.SetTrigger("attack1");

        }
    }
}
