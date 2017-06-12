using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : IPlayerMovement
{


    public override void Movement(float forwardSpeed, float HorizSpeed, float[] Lanes, int currLane)
    {

        var rigid = transform.GetComponent<Rigidbody>();

        rigid.velocity = forwardSpeed * transform.forward * Time.fixedDeltaTime;

        Vector3 pos = rigid.position;
        pos.x = Mathf.Lerp(pos.x, Lanes[currLane], HorizSpeed * Time.fixedDeltaTime);

        rigid.position = pos;
    }



}
