using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptusu : MonoBehaviour
{
    bool pause;

    void Start()
    {
        pause = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
        }
        if(pause)
        {
            Time.timeScale = 0;
        }
        else if(!pause)
        {
            Time.timeScale = 1;
        }
    }
}
