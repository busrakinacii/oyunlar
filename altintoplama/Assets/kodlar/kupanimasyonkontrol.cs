using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupanimasyonkontrol : MonoBehaviour
{
    float sayac = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        sayac -= Time.deltaTime;
        if (sayac < 0)
        {
            GetComponent<Animator>().Play(0);
            sayac = Random.Range(4, 6);
        }
    }
}
