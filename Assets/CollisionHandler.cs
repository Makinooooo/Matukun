using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // ���������Ƃ��ɌĂ΂�郁�\�b�h
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �Փ˂����I�u�W�F�N�g��Player�^�O�������Ă��邩�`�F�b�N
        if (other.CompareTag("Player"))
        {
            // �����i���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g�j��j������
            Destroy(gameObject);
        }
    }
}
