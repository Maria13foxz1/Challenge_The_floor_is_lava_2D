using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private bool isGrounded;
    public float jump;
    public float speed;
    public AudioSource audioSourceJump;
    public AudioSource audioSourceBreak;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x += Input.GetAxis("Horizontal")*speed;
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            isGrounded = false;
            audioSourceJump.Play();
            rigidbody.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Finish")
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Floor")
        {
            audioSourceBreak.Play();
            Destroy(gameObject);
        }
    }
}
