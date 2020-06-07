using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableDialogue : MonoBehaviour
{
    public GameObject DialogueSheet;
    public GameObject FOnScreen;
    public bool playerInRange;
    public BoxCollider2D trigger;

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

              if(DialogueSheet.activeInHierarchy)
              {
                DialogueSheet.SetActive(false);


              }
              else
              {
                DialogueSheet.SetActive(true);



              }
    }
  }

    void OnTriggerEnter2D(Collider2D other2)
    {
      if (other2.CompareTag("Player"))
      {
        playerInRange = true;
        FOnScreen.SetActive(true);
    }
}
void OnTriggerExit2D(Collider2D other2)
{
  if (other2.CompareTag("Player"))
  {
    playerInRange = false;
    FOnScreen.SetActive(false);
  }
}

}
