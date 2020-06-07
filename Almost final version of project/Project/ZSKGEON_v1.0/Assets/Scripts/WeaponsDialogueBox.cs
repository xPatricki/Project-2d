using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsDialogueBox : MonoBehaviour
{
    public GameObject FOnScreen;
    public bool playerInRange;
    public GameObject DialogueBox;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F) && playerInRange)
        {
            if(DialogueBox.activeInHierarchy)
              {
                DialogueBox.SetActive(false);
              }
            else
              {
                DialogueBox.SetActive(true);
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
  if (other.gameObject.tag == "Player")
  {
    playerInRange = false;
    FOnScreen.SetActive(false);

  }
}

}
