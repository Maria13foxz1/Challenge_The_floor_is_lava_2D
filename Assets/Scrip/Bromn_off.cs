using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bromn_off : MonoBehaviour
{
    public float speed = 2.0f; // Швидкість руху платформи
    public float distance; // Відстань, на яку платформа буде переміщатися

    private Vector3 startPos; // Початкова позиція платформи

    void Start()
    {
        startPos = transform.position; // Зберегти початкову позицію
    }

    void Update()
    {
        // Рухаємо платформу вліво і вправо в заданому діапазоні
        float newPositionX = startPos.x + Mathf.PingPong(Time.time * speed, distance) - distance / 2;
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
