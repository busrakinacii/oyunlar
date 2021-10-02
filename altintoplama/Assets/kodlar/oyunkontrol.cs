using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public bool oyunaktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayisiText;

   
    void Start()
    {
        GetComponent<AudioSource>().Play();
        oyunaktif = true;
    }
    
    void Update()
    {
        
    }
   public void altinarttir()
    {
        altinSayisi += 1;
        altinSayisiText.text = "" + altinSayisi;
        if (altinSayisi == 5)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
