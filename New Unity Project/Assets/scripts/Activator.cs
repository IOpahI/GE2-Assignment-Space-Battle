using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    public BigBoid big;
    private Boid boid;
    private Pursue pursue;
    private ObstacleAvoidance obs;
    private NoiseWander noise;
    private Constrain con;

    // Start is called before the first frame update
    void Start()
    {
        boid = GetComponent<Boid>();
        pursue = GetComponent<Pursue>();
        obs = GetComponent<ObstacleAvoidance>();
        noise = GetComponent<NoiseWander>();
        con = GetComponent<Constrain>();
    }

    // Update is called once per frame
    void Update()
    {


        if(big.finished == true)
        {
            
            boid.enabled = true;
            pursue.enabled = true;
            obs.enabled = true;
            noise.enabled = true;
            con.enabled = true;
            big.enabled = false;
        }
        
    }
}
