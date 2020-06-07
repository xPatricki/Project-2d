using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorToHalfFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "HalfFloor")
        {
            player.position = new Vector2(2.1f, -20.9f);
            Camera.main.transform.position = new Vector3(2.1f, -20.9f, -10f);
        }
    }

}