using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouShallNotPass2 : MonoBehaviour
{
  public GameObject YouCantGoThere;
  public BoxCollider2D collidero;
  public BoxCollider2D triggero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(CellarWeapon.gotWeapon)
      {
        Destroy(collidero);
        Destroy(triggero);
      }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
      YouCantGoThere.SetActive(true);

    }
    void OnTriggerExit2D(Collider2D collision)
    {
      YouCantGoThere.SetActive(false);

    }
}
