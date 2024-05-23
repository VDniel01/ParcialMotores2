using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll_atravesar : Controller_Player
{
    public GameObject wallPrefab;
    public GameObject wall;

    public override bool IsOnSomething()
    {
        return Physics.BoxCast(transform.position, new Vector3(transform.localScale.x * 0.9f, transform.localScale.y / 3, transform.localScale.z * 0.9f), Vector3.down, out downHit, Quaternion.identity, downDistanceRay);
    }

    public override void Jump()
    {
        wall = GameObject.FindWithTag("Wall");
        if (wall != null)
        {
            // Código para atravesar la pared
        }
    }
}
