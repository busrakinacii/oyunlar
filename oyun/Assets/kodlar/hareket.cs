using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Rigidbody rbd;
    public int hiz;

    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float hareketx = Input.GetAxisRaw("Horizontal");
        float harekety = Input.GetAxisRaw("Jump");
        float hareketz = Input.GetAxisRaw("Vertical");
        Vector3 yon = new Vector3(hareketx, 0f, hareketz);
        rbd.AddForce(yon * hiz);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rbd.AddForce(new Vector3(0, 300, 0));
        }

    }
}
