using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hikakin : MonoBehaviour
{
    public float speed = 4f;
    private float playerSpeed;
    Rigidbody2D rigidbody2D;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // 左キーを押したら左方向へ進む
        if (Input.GetKey(KeyCode.A)) playerSpeed = -speed;
        // 右キーを押したら右方向へ進む
        else if (Input.GetKey(KeyCode.D)) playerSpeed = speed;
        // 何もおさなかったら止まる
        else playerSpeed = 0;

        rigidbody2D.velocity = new Vector2(playerSpeed, rigidbody2D.velocity.y);

        float moveX = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveX, 0);
        rigidbody2D.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * jumpPower;
        }
    }
}
