using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfFloorToFirstFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "FirstFloor")
        {
            player.position = new Vector2(-213.9f, 338.05f);
            Camera.main.transform.position = new Vector3(-213.9f, 338.05f, -10f);
        }
    }

}