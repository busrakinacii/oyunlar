using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helhareket : MonoBehaviour
{
    Rigidbody helfizik;
    void Start()
    {
        transform.Rotate(new Vector3(0, -90, 0));
        helfizik = GetComponent<Rigidbody>();
        helfizik.velocity = new Vector3(-20, 0, 0);

    }

    void Update()
    {
        if (transform.position.x <= -300)
        {
            Destroy(gameObject);
        }
    }
}
