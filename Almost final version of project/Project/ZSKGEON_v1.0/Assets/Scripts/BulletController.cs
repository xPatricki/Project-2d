using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    public int damageToGive = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Enemy")
      {
        collision.gameObject.GetComponent<RedBlackEnemy>().Damage(damageToGive);
      }
      Destroy(gameObject, 1);
    }

}
