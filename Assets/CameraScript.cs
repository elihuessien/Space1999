using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    Vector3 position;
    EagleSpawner es;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        es = FindObjectOfType<EagleSpawner>();

        //if there is a leader then look at him
        if (es.fleet.Count > 0)
        {
            position = es.fleet[0].transform.position;
            this.transform.LookAt(position);
        }
    }
}
