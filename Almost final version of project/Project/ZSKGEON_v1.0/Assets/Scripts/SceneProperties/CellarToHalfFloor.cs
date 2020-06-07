using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellarToHalfFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "HalfFloor")
        {
            player.position = new Vector2(-32.93f, 117.05f);
            Camera.main.transform.position = new Vector3(-32.93f, 117.05f, -10f);
        }
    }

}