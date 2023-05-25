using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float damage = 20.0f;
    public float force = 1500.0f;
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody 컴포넌트를 추출
        rb = GetComponent<Rigidbody>();
        // 총알의 전진 방향으로 힘(Force)을 가한다.
        rb.AddForce(transform.forward * force);
    }
}
