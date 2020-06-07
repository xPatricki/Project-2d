using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
  public GameObject car;
  public Transform portal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.tag == "car")
      {
        Debug.Log("car!");
        car.transform.position = portal.position;
      }
    }
}
