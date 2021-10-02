using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heluret : MonoBehaviour
{
    public GameObject hel;
    void Start()
    {
        StartCoroutine(helyap());
    }
    
    IEnumerator helyap()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            Vector3 koordinat = new Vector3(40, Random.Range(10.0f, 24.0f), Random.Range(10.0f, 65.0f));
            Instantiate(hel, koordinat, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
