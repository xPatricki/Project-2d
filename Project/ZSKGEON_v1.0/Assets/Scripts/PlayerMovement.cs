using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    private float lastFire;
    public float firedelay;
    public GameObject bulletPrefab;
    public float bulletSpeed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    void Update()
    {
      float ShootHorizontal = Input.GetAxis("HorizontalShoot");
      float ShootVertical = Input.GetAxis("VerticalShoot");
      if(ShootVertical != 0 || ShootHorizontal !=0 && Time.time > lastFire + firedelay && CellarWeapon.gotWeapon)
      {
        Shoot(ShootVertical, ShootHorizontal);
        lastFire = Time.time;
      }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();

    }
    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("MoveX", change.x);
            animator.SetFloat("MoveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
    void Shoot(float x, float y)
    {
      GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
      //bullet.GetComponent<Rigidbody2D>().gravity = 0;
      bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
      (y <0) ? Mathf.Floor(y) *bulletSpeed : Mathf.Ceil(y) *bulletSpeed,
      (x <0) ? Mathf.Floor(x) *bulletSpeed : Mathf.Ceil(x) *bulletSpeed,
      0);
    }
    
}
