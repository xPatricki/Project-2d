using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedBlackEnemy : Enemy
{

private Rigidbody2D myRigidBody;
public Transform target;
public float chaseRadius;
public float attackRadius;
public Transform homePosition;
public string enemyName;
public int baseAttack;
public float moveSpeed;
public static bool IsTouching;
public int MaxHealth = 4;
public int CurrentHealth;
public int damageToDeal = 1;
public Health health;


    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        myRigidBody = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
        if(CurrentHealth<=0)
        {
          gameObject.SetActive(false);
          EnemyCounter.counter += 1;
        }

    }

    void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            myRigidBody.MovePosition(temp);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.CompareTag("Bullet"))
      {
        Damage(1);
        Debug.Log("trafiony!");
      }
      if (collision.gameObject.tag == "Player")
      {
        IsTouching = true;
        Debug.Log("Touching");
      }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.CompareTag("Bullet"))
      {

        Debug.Log("nie trafiony!");
      }
    if (collision.CompareTag("Player"))
    {
      IsTouching = false;
      health.GetDamage(1);
      Debug.Log("Not touching");
    }
    }
    public void Damage(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }
}
