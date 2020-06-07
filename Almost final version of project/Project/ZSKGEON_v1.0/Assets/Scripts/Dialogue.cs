using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    public GameObject f;
    public GameObject dialogueBox;
    public bool playerInRange;
    public Text dialogueText;
    public string Dailoguename = "";
    [TextArea]
    public string dialogue;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.F) && playerInRange)
        {
          if(dialogueBox.activeInHierarchy)
          {
            dialogueBox.SetActive(false);



          }
          else
          {
            dialogueBox.SetActive(true);
            dialogueText.text = dialogue;
          }

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        playerInRange = true;
        f.SetActive(true);
      }
    }

    void OnTriggerExit2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        playerInRange = false;
        dialogueBox.SetActive(false);
        f.SetActive(false);
      }
    }

}
