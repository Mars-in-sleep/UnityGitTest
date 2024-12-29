using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 矢印キーの入力を取得
        float moveHorizontal = Input.GetAxis("Horizontal"); // 左右キー
        float moveVertical   = Input.GetAxis("Vertical");   // 上下キー

        // 入力に基づいて移動ベクトルを計算
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbodyを使用して球を移動
        rb.AddForce(movement * moveSpeed);

    }
}
