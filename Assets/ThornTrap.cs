using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornTrap : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // 例えば、"Player"というタグを持つオブジェクトに当たった場合
        {
            Debug.Log("Playerに当たりました！");
        }
    }
}
