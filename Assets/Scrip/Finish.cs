using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Finish : MonoBehaviour
{
    public AudioSource audioSource;
    public TextMeshProUGUI GameOverText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ����������, �� ��� ��������� ��'���� ������� � �������� �����
        if (collision.gameObject.tag == "Player")
        {
            GameOverText.gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}
