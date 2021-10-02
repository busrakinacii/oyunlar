using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topmermisi : MonoBehaviour
{
    Rigidbody mermifizik;
    public int hiz;
    public GameObject yer;
    public GameObject zemin;
    public GameObject patlama;

    void Start()
    {
        yer = GameObject.Find("MuzzleFlash");
        mermifizik = GetComponent<Rigidbody>();
        mermifizik.velocity = yer.transform.forward * hiz;
        zemin = GameObject.Find("zeminn");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "zemin")
        {
            Instantiate(patlama, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
