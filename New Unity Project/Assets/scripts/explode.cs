using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{

    public ParticleSystem parts;
    public AudioClip explodsion;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
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

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.8f);
        this.gameObject.SetActive(false);
    }
}
