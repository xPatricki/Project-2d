using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWeapons : MonoBehaviour
{
    public GameObject uselessWeapons;
    public GameObject DialogueSheetToDestroy;
    void Update()
    {
        if(CellarWeapon.gotWeapon)
        {
          Destroy(uselessWeapons);
          
        }
    }
}
