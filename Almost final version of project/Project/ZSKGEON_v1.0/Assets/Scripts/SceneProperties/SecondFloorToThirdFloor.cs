using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorToThirdFloor : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "ThirdFloor")
        {
            player.position = new Vector2(-1.7f, -31f);
            Camera.main.transform.position = new Vector3(-1.7f, -31f, -10f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {}

}
