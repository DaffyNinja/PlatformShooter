using UnityEngine;
using System.Collections;

public class EnemyTwoShoot : MonoBehaviour
{

    public GameObject bulletOBj;

    public Transform bulletShot;


    public float playerHitDistance;

    public LayerMask playerMask;


    bool shoot;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, playerHitDistance, playerMask);
        if (hit)
        {
           // print("player");

            shoot = true;

           // Debug.DrawLine(transform.position, hit.point, Color.red, playerHitDistance);
    
        }
        else
        {
            shoot = false;

            //print("Not there");
        }

        //Debug.DrawLine(transform.position, hit.point, Color.red, playerHitDistance);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
        // {

        // }

        if (shoot == true)
        {
            Instantiate(bulletOBj, new Vector3(bulletShot.transform.position.x, bulletShot.transform.position.y, bulletShot.transform.position.z), transform.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "RW")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        }

        if (col.gameObject.tag == "Right Door")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "Left Door")
        {

            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.name == "LW")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        }


        if (col.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

}

