﻿using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sayac : MonoBehaviour
{
    public Text sayactext;
    int sayacstart = 0;

    void Start()
    {
        StartCoroutine(zamanuret());
    }

    void Update()
    {
        
            sayactext.text = "Zaman:" + sayacstart;
        
    }
    IEnumerator zamanuret()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            sayacstart++;
            yield return new WaitForSeconds(1);
        }
    }
}
