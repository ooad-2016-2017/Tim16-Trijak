using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forwardSpeed = 10;
    public float HorizSpeed = 100;

    public float[] Lanes;

    private int currLane = 0;

    public delegate void OnDeathDelegate();

    public event OnDeathDelegate OnDeath;

    public GameManager gameManager;

    public int Score
    {
        get { return gameManager.Score; }
    }

    // Use this for initialization
    void Start()
    {

        Array.Sort(Lanes);

        currLane = Lanes.Length / 2;
    }

    void Update()
    {

        if (Input.GetButtonDown("MoveRight")) currLane++;
        else if (Input.GetButtonDown("MoveLeft")) currLane--;

        currLane = Mathf.Clamp(currLane, 0, Lanes.Length - 1);
    }

    public IPlayerMovement move;

    void FixedUpdate()
    {
        move.Movement(forwardSpeed, HorizSpeed, Lanes, currLane);


    }



    // void FixedUpdate()
    // {

    /*var rigid = transform.GetComponent<Rigidbody>();

    rigid.velocity = forwardSpeed * transform.forward * Time.fixedDeltaTime;

    Vector3 pos = rigid.position;
    pos.x = Mathf.Lerp(pos.x, Lanes[currLane], HorizSpeed * Time.fixedDeltaTime);

    rigid.position = pos;*/
    // }


    public void Die()
    {
        if ( OnDeath != null )
            OnDeath();
        Destroy(gameObject);
    }

    public void GetPowerup(int points)
    {
        gameManager.AddPoints(points);
    }
}
