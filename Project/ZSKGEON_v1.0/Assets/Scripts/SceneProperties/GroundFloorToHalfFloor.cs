using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFloorToHalfFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "HalfFloor")
        {
            player.position = new Vector2(4.85f, 3.59f);
            Camera.main.transform.position = new Vector3(4.85f, 3.59f, -10f);
        }
    }

}