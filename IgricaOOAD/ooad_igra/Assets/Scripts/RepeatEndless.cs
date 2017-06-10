using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatEndless : MonoBehaviour {
    public Transform player;

    public float offsetZ = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!player) return;

        if ( player.position.z - transform.position.z > 10 ) 
            transform.position += new Vector3(0, 0, offsetZ);
	}
}
