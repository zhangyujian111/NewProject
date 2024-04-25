using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbody2D;
    public float jumpPower = 10;
    private bool isOnGround = true;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
       // float v = Input.GetAxis("Vertical");
        Vector3 V3 = new Vector3(h, 0, 0);
        transform.Translate(V3 * Time.deltaTime * speed);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rigidbody2D.AddForce(Vector2.up * jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            isOnGround = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            isOnGround = false;
        }
    }

}
