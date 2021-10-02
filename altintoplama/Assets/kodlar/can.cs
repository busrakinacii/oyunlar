using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can : MonoBehaviour
{

    int oyuncununcani = 3;
    List<GameObject> canresim = new List<GameObject>();
    int i = 0;
    GameObject can1;
    GameObject can2;
    GameObject can3;
    GameObject can4;

    void Start()
    {
        can1 = GameObject.Find("Can1");
        can2 = GameObject.Find("Can2");
        can3 = GameObject.Find("Can3");
        can4 = GameObject.Find("Can4");
        canresim.Add(can1);
        canresim.Add(can2);
        canresim.Add(can3);
        canresim.Add(can4);

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "dusman")
        {
            Destroy(col.gameObject);
            oyuncununcani--;
            Destroy(canresim[i]);
            i++;
        }
        if (oyuncununcani == 0)
        {
         
            Destroy(gameObject);
        }
    }
  }
