using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bromn_off : MonoBehaviour
{
    public float speed = 2.0f; // �������� ���� ���������
    public float distance; // ³������, �� ��� ��������� ���� �����������

    private Vector3 startPos; // ��������� ������� ���������

    void Start()
    {
        startPos = transform.position; // �������� ��������� �������
    }

    void Update()
    {
        // ������ ��������� ���� � ������ � �������� �������
        float newPositionX = startPos.x + Mathf.PingPong(Time.time * speed, distance) - distance / 2;
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
