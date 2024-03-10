using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Перевіряємо, чи тег зіткненого об'єкта співпадає з цільовим тегом
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
