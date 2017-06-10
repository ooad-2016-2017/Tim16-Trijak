using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPosition : MonoBehaviour
{

    public float fixedX = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 pos = transform.position;
	    pos.x = fixedX;

	    transform.position = pos;
	}
}
