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
        // �v���C���[�̈ړ�
        MovePlayer();

        // �W�����v
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
        // �W�����v������ǉ�����
    }

    // �Փ˔���
    void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂����I�u�W�F�N�g���{�[���ł���΃v���C���[������
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject); // �v���C���[������
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // �{�[���̏�ɏ���Ă���ꍇ�����n�����Ƃ݂Ȃ�
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // �󒆂ɂ���ꍇ�͒��n���Ă��Ȃ��Ƃ���
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
