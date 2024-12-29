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
        // ���L�[�̓��͂��擾
        float moveHorizontal = Input.GetAxis("Horizontal"); // ���E�L�[
        float moveVertical   = Input.GetAxis("Vertical");   // �㉺�L�[

        // ���͂Ɋ�Â��Ĉړ��x�N�g�����v�Z
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbody���g�p���ċ����ړ�
        rb.AddForce(movement * moveSpeed);

    }
}
