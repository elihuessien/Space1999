using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {
    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;
    public List<GameObject> fleet;

    // Use this for initialization
    void Awake () {
        //spawn first eagle
        Vector3 position = this.transform.position;

        //make them look forward
        Vector3 rot = new Vector3(0, 90, 0);
        Quaternion rotation = Quaternion.Euler(rot);
        //temporary Gameobject
        GameObject g;

        for (int i = 0; i <= followers; i++)
        {
            //make one leader
            if (i == 0)
            {
                g = (GameObject)Instantiate(prefab, position, rotation);
                //add neccessary scripts
                g.AddComponent<Seek>();
                fleet.Add(g);
            }
            else // make followers
            {
                //get new position
                Vector3 Xspace = new Vector3(gap * i, 0, 0);
                Vector3 Zspace = new Vector3(0, 0, gap * i);
                Vector3 left = position + Xspace - Zspace;
                Vector3 right = position - Xspace - Zspace;

                //instantiate level of followers
                g = (GameObject)Instantiate(prefab, left, rotation);
                g.AddComponent<OffsetPursue>();
                fleet.Add(g);
                g = Instantiate(prefab, right, rotation);
                g.AddComponent<OffsetPursue>();
                fleet.Add(g);
            }

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
