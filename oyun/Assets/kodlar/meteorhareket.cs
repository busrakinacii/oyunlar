﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorhareket : MonoBehaviour
{
    Rigidbody meteorfizik;
    // Start is called before the first frame update
    void Start()
    {
        meteorfizik = GetComponent<Rigidbody>();
        meteorfizik.velocity = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
