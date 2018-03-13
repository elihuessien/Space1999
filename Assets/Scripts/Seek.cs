using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {
    Boid b;
    float weight;

	// Use this for initialization
	void Start () {
        b = GetComponent<Boid>();
        weight = 5;
	}
	
	// Update is called once per frame
	void Update () {
        //seek a point 1000 units ahead of yourself
        Vector3 dir = Vector3.forward * 1000;

        WeightedSteer ws = new WeightedSteer(dir, weight);
        b.directions.Add(ws);
	}
}
