using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornTrap : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // �Ⴆ�΁A"Player"�Ƃ����^�O�����I�u�W�F�N�g�ɓ��������ꍇ
        {
            Debug.Log("Player�ɓ�����܂����I");
        }
    }
}
