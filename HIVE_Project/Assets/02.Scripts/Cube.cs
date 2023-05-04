using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Rigidbody rb;
    Transform tr;
    float pVelocity = 40.0f;
    float v, h;
    float yRot, yRotMove;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(Vector3.forward * Time.deltaTime * v * pVelocity);


       
    }
}
