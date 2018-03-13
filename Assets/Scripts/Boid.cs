using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {
    public float mass;
    public float maximumSpeed;

    //I used wieghted steer to make the code more adaptive
    //in case more behaviours were to be added, It would be able to cope
    public List<WeightedSteer> directions;
    Rigidbody rb;



	// Use this for initialization
	void Start () {
        mass = 1;
        maximumSpeed = 10;
        directions = new List<WeightedSteer>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //Calculate dirrection to go in
        Vector3 dir = Vector3.zero;
        foreach (WeightedSteer s in directions)
        {
            dir = s.steer * s.weight;
        }


        //Move in that dirrection at full speed direction
        dir = dir.normalized * maximumSpeed;
        rb.AddForce(dir);
	}
}
