using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPlayerMovement : MonoBehaviour
{

    public abstract void Movement(float forwardSpeed, float HorizSpeed, float[] Lanes, int currLane);

}
