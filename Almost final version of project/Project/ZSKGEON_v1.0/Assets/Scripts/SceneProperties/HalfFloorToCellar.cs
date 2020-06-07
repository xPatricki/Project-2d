using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfFloorToCellar : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Cellar")
        {
            player.position = new Vector2(-222.69f, 333.43f);
            Camera.main.transform.position = new Vector3(-222.69f, 333.43f, -9.9f);
        }
    }

}