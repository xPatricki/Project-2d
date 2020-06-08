using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorToFirstFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "FirstFloor")
        {
            player.position = new Vector2(-2.2f, -34.8f);
            Camera.main.transform.position = new Vector3(-2.2f, -34.8f, -10f);
        }
    }

}