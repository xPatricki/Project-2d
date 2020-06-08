using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdFloorToSecondFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "SecondFloor")
        {
            player.position = new Vector2(-3.7f, -41.7f);
            Camera.main.transform.position = new Vector3(-3.7f, -41.7f, -10f);
        }
    }

}