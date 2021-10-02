using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kivilcim : MonoBehaviour
{
    public GameObject kivilcimFX;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(kivilcimFX, other.transform.position, other.transform.rotation);
    }
}
