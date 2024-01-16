using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // 当たったときに呼ばれるメソッド
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突したオブジェクトがPlayerタグを持っているかチェック
        if (other.CompareTag("Player"))
        {
            // 自分（このスクリプトがアタッチされているオブジェクト）を破棄する
            Destroy(gameObject);
        }
    }
}
