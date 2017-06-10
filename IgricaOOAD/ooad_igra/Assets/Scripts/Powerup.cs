using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        var player = col.transform.GetComponent<Player>();

        if (player)
        {
            player.GetPowerup(1);

            Destroy(gameObject);
        }
    }
}
