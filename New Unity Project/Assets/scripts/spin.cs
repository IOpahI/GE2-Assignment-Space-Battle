using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public BigBoid bb;
    public AudioSource ads;
    public AudioClip explosion;
    public GameObject[] ships;
    public Rigidbody rigid;
    private bool locked = false;
    public bool explosionlock = false;
    private bool goodbye = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid.GetComponent<Rigidbody>();
        ads.GetComponent<AudioSource>();
        bb.GetComponent<BigBoid>();
        GameObject[] ships = GameObject.FindGameObjectsWithTag("EnemyShip");
    }

    // Update is called once per frame
    void Update()
    {
        if(bb.spun == true)
        {
            if(locked == false)
            {
                StartCoroutine("done");
            }
            
            this.transform.Rotate(+5, +5, +5);
        }
        if(goodbye == true)
        {
            rigid.velocity = transform.forward  * 15;
        }
    }

    IEnumerator done()
    {
        locked = true;
        yield return new WaitForSeconds(0.8f);
        ads.PlayOneShot(explosion);
        explosionlock = true;
        yield return new WaitForSeconds(0.8f);

        yield return new WaitForSeconds(5);
        goodbye = true;
        bb.spun = false;

    }
}
