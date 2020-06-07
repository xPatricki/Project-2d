using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfFloorToGroundFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
      
        base.Start();

        if (prevScene == "GroundFloor")
        {
            player.position = new Vector2(-213.9f, 328.41f);
            Camera.main.transform.position = new Vector3(-213.9f, 328.41f, -10f);
        }
    }

}
