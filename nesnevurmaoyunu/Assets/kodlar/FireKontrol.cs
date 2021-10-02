using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireKontrol : MonoBehaviour
{
    public GameObject muzzlepatlama;
    AudioSource namluses;
    public GameObject firebutton;
    public GameObject topmermisi;

    void Start()
    {
        namluses = GetComponent<AudioSource>();
        firebutton = GameObject.Find("ateş");
    }

    public void Fire()
    {
        Instantiate(muzzlepatlama, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(topmermisi, gameObject.transform.position, gameObject.transform.rotation);
        namluses.Play();
        firebutton.SetActive(false);
        StartCoroutine(refresh());
       //çalıştırmadı// Destroy(muzzlepatlama);
    }
    public IEnumerator refresh()
    {
        yield return new WaitForSeconds(1.0f);
        firebutton.SetActive(true);
    }

    void Update()
    {
    }

}
