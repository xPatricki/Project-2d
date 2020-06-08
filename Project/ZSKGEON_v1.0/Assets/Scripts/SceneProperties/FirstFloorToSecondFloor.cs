using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorToSecondFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "SecondFloor")
        {
            player.position = new Vector2(3f, -20f);
            Camera.main.transform.position = new Vector3(3f, -20f, -10f);
        }
    }

}
