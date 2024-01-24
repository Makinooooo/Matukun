using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded;

    void Update()
    {
        // プレイヤーの移動
        MovePlayer();

        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0f));
    }

    void Jump()
    {
        // ジャンプ処理を追加する
    }

    // 衝突判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトがボールであればプレイヤーを消す
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject); // プレイヤーを消す
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // ボールの上に乗っている場合も着地したとみなす
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // 空中にいる場合は着地していないとする
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
