using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{
    int left = 20;
    public bool leftkontrol = false;
    GameObject vurucu;
    void Start()
    {
        vurucu = GameObject.Find("vurucu");
    }
    public void soladon()
    {
        leftkontrol = true;
    }

    public void kes()
    {
        leftkontrol = false;
    }

    void Update()
    {
        if (leftkontrol == true)
            vurucu.transform.Rotate(-Vector3.up*left*Time.deltaTime);
    }
}
