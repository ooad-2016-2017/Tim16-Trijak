using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    public Vector3 defaultPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!target)
	    {
	        transform.position = defaultPos;
	        return;
	    }

	    transform.position = target.position + offset;
	}
}
