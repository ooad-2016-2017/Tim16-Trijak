using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform player;

    private bool destroyed = false;

	// Use this for initialization
	void Start ()
	{
	}

    public void onDeath()
    {
        if ( !destroyed )
            Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (!player) return;

	    if (player.position.z - transform.position.z > 10)
	    {
	        destroyed = true;
	        Destroy(gameObject);
	    }
	}


    void OnCollisionEnter(Collision col)
    {
        var player = col.transform.GetComponent<Player>();

        if (player)
        {
            player.Die();
        }
    }
}
