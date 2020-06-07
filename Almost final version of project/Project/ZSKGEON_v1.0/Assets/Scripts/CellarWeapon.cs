using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellarWeapon : MonoBehaviour
{
  public static bool gotWeapon;
  public GameObject DialogueSheet;
  public GameObject FOnScreen;
  public bool playerInRange;
  public BoxCollider2D trigger;
  public GameObject disablerator;
  public GameObject uselessObjects;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playerInRange)
            {
              Destroy(trigger);
              disablerator.SetActive(false);
              gotWeapon = true;

              if(DialogueSheet.activeInHierarchy)
              {
                DialogueSheet.SetActive(false);


              }
              else
              {
                DialogueSheet.SetActive(true);
                gotWeapon = true;


              }
    }
  }
    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        playerInRange = true;
        FOnScreen.SetActive(true);
    }
}
void OnTriggerExit2D(Collider2D other)
{
  if (other.CompareTag("Player"))
  {
    playerInRange = false;
    FOnScreen.SetActive(false);
  }
}

}
