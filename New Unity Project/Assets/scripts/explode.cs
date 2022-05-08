using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{

    public ParticleSystem parts;
    public AudioClip explodsion;
    public AudioSource audio;

    public spin sprinscript;
    private bool doubleLocked = false;
    // Start is called before the first frame update
    void Start()
    {
        sprinscript.GetComponent<spin>();
        audio.GetComponent<AudioSource>();
        parts.GetComponentInChildren<ParticleSystem>();
        parts.Pause();
    }

    void OnCollisionEnter(Collision collision)
    {
        audio.PlayOneShot(explodsion);
        Instantiate(parts, transform.position, Quaternion.identity);
        StartCoroutine("delay");
        
    }

    void Update()
    {
        if(sprinscript.explosionlock == true && doubleLocked == false)
        {
            doubleLocked = true;
            Instantiate(parts, transform.position, Quaternion.identity);
            StartCoroutine("delay");
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.8f);
        this.gameObject.SetActive(false);
    }
}
