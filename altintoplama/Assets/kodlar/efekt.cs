﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efekt : MonoBehaviour
{
    public GameObject kivilcimFX;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(kivilcimFX, other.transform.position, other.transform.rotation);
    }
}
