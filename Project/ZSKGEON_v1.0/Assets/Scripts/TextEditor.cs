using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour
{
  public Text textCounter;
  private string CounterText;
    // Start is called before the first frame update
    void Start()
    {
      CounterText = EnemyCounter.counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CounterText = EnemyCounter.counter.ToString();
        textCounter.text = CounterText;
    }
}
