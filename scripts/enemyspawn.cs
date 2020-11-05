using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemySpawn;
    public float fireRate;

    private float nextFire;


    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(enemy, enemySpawn.position, enemySpawn.rotation);
        }

    }

}
