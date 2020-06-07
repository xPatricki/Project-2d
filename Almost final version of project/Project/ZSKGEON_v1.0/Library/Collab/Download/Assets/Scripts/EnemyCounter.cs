using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
  public static int counter = 0;
  public BoxCollider2D collidation;
  public BoxCollider2D triggerr;

  public BoxCollider2D collidation2;
  public BoxCollider2D triggerr2;

    // Start is called before the first frame update
    void Start()
    {
      counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if(counter == 1)
      {
        Destroy(collidation);
        Destroy(triggerr);
      }
      else if (counter == 2) {
        Destroy(collidation2);
        Destroy(triggerr2);
      }
    }
}
