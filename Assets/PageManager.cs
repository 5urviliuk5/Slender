using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public Flashlight flashlight;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        pages++;

        if (pages == 1)
        {
            enemy.target = transform;
        }

        if (pages == 2)
        {
            enemy.speed *= 2;
        }

        if (pages == 3)
        {
            enemy.viewDistance *= 1.5f;
        }

        if (pages == 4)
        {
            flashlight.decreaseRate = 5f;
        }

        if (pages == 5)
        {
            flashlight.isOn = false;
        }

        if (pages == 6)
        {
            enemy.speed = 2;
            enemy.viewDistance += 1000;
        }
    }
}
