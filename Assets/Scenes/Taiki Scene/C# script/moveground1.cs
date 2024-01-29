using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveground1 : MonoBehaviour
{
    private Vector3 initialPosition;  // オブジェクトの初期位置を保存する変数
    public float moveSpeed = 3.0f;  // 上下の移動速度

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;  // 初期位置を保存
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトを上方向に動かす
        transform.position = new Vector3(initialPosition.x, initialPosition.y - Mathf.Sin(Time.time) * moveSpeed, initialPosition.z);
    }
}
