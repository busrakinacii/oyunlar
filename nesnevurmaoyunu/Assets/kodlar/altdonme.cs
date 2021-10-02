using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altdonme : MonoBehaviour
{
    int right = 20;
    public bool rightkontrol = false;
    GameObject vurucu;
    void Start()
    {
        vurucu = GameObject.Find("vurucu");
    }
    public void sagadon()
    {
        rightkontrol = true;
    }

    public void sagkes()
    {
        rightkontrol = false;
    }

    void Update()
    {
        if (rightkontrol == true)
            vurucu.transform.Rotate(Vector3.right * right * Time.deltaTime);
    }
}
