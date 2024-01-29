using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveground1 : MonoBehaviour
{
    private Vector3 initialPosition;  // �I�u�W�F�N�g�̏����ʒu��ۑ�����ϐ�
    public float moveSpeed = 3.0f;  // �㉺�̈ړ����x

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;  // �����ʒu��ۑ�
    }

    // Update is called once per frame
    void Update()
    {
        // �I�u�W�F�N�g��������ɓ�����
        transform.position = new Vector3(initialPosition.x, initialPosition.y - Mathf.Sin(Time.time) * moveSpeed, initialPosition.z);
    }
}
