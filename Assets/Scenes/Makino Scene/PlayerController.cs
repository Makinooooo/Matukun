using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 400.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �W�����v
        if (Input.GetKeyDown(KeyCode.Space) &&
            this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // ���E�ړ�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // ���x
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // �X�s�[�h����
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // �����ɉ����Ĕ��]
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // ���x�ɉ����ăA�j���[�V����
        this.animator.speed = speedx / 2.0f;
    }
}
