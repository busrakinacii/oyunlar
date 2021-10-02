using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
//using System.Collections.Specialized;
//using UnityEngine.Random;
//using System.Random;

public class meteoruret : MonoBehaviour
{

    public GameObject[] meteorlar;
    int meteorsecimi;

    void Start()
    {
        StartCoroutine(meteoryap());
    }

    IEnumerator meteoryap()
    {
        for (int i=0; i<=20; i++)
         { 
        yield return new WaitForSeconds(2);
        GameObject nb = Instantiate(meteorlar[Random.Range(0, meteorlar.Length)], this.transform) as GameObject;
        nb.transform.localPosition = new Vector3(Random.Range(3, 7), 5, -10);
        }
    }
    /*IEnumerator meteoryap()
    {
        yield return new WaitForSeconds(1);
        while(true)
        {
            Vector3 meteorkoordinat = new Vector3(Random.Range(3, 7), 5, -10);
            meteorsecimi = Random.Range(0, meteorlar.Length);
            Instantiate(meteorlar[meteorsecimi], meteorkoordinat, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }*/
}
