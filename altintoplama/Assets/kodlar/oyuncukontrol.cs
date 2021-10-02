using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncukontrol : MonoBehaviour
{
    public AudioClip altin, dusme;
    public oyunkontrol oyunK;
    private float hiz = 10;
 
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
    void Update()
    {
        if (oyunK.oyunaktif)
        {


            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }

        void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin")) {

            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
            oyunK.altinarttir();
            GetComponent<AudioSource>().Play();
            Destroy(c.gameObject);
          
          }
        if (c.gameObject.tag.Equals("dusman"))
        {

            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            // oyunK.oyunaktif = false;
            //  Destroy(c.gameObject);
            oyuncununcani--;
            Destroy(canresim[i]);
            i++;
        }
        if (c.gameObject.tag.Equals("dusman1"))
        {

            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            oyunK.oyunaktif = false;
            Destroy(c.gameObject);
            SceneManager.LoadScene("menu");

        }
        if (oyuncununcani == 0)
        {
            Destroy(c.gameObject);
            oyunK.oyunaktif = false;
          SceneManager.LoadScene("menu");
    
         }
    }
}
