using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursue : MonoBehaviour {
    Boid b;
    GameObject leader;
	// Use this for initialization
	void Start () {
        b = GetComponent<Boid>();
        EagleSpawner es = FindObjectOfType<EagleSpawner>();
        leader = es.fleet[0];
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = leader.GetComponent<Rigidbody>();
        //get target
        Vector3 target = leader.transform.position + rb.velocity;

        //calculate direction
        Vector3 dir = target - transform.position;
        float weight = 5;

        WeightedSteer ws = new WeightedSteer(dir, weight);
        b.directions.Add(ws);
    }
}
