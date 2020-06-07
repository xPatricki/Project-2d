using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueKey : MonoBehaviour
{
    public GameObject f;
    public GameObject dialogueBox;
    public GameObject narrator;
    public bool playerInRange;
    public Text dialogueText;
    public string dialoguename;
    [TextArea]
    public string dialogue;
    public static bool destroy1st;
    public static bool destroy2nd;
    private static bool destroy3rd;
    private static bool destroy4th;



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
            narrator.SetActive(false);
          }
          else
          {
            dialogueBox.SetActive(true);
            narrator.SetActive(true);
            dialogueText.text = dialogue;
            destroy1st = true;
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
        narrator.SetActive(false);
        f.SetActive(false);
      }
    }

}
