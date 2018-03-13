using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedSteer : MonoBehaviour {

    public readonly float weight;
    public readonly Vector3 steer;

    public WeightedSteer( Vector3 s, float w)
    {
        steer = s;
        weight = w;
    }
}
