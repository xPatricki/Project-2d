using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouShallNotPass : DialogueKey
{
    private static bool destroy1stt;

    public GameObject TitleOnScreen;
    public BoxCollider2D block1st;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        destroy1stt = DialogueKey.destroy1st;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        TitleOnScreen.SetActive(true);
          if(destroy1stt)
          {
            TitleOnScreen.SetActive(false);
            block1st.enabled=false;
          }

    }
    void OnTriggerExit2D(Collider2D other)
    {
      TitleOnScreen.SetActive(false);
    }
}
