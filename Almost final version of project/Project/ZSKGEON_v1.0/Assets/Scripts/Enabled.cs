using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enabled : MonoBehaviour
{
  public GameObject CDN;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
      if(CellarWeapon.gotWeapon)
      {
        CDN.SetActive(true);
      }
    }
}
