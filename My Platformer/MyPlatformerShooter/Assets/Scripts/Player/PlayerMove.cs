using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;

    public float jumpSpeed;


    public LayerMask groundMask;

    public float jumpDistance;

    bool canJump;


    float fMove;

    bool isFacingRight = true;


    public bool isRight;

    public bool isLeft;


    public float health;

    public Slider helthBar;

    private Rigidbody2D myRigidbody2D;


    // Use this for initialization
    void Start()
    {
        //isRight = true;

        myRigidbody2D = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, jumpDistance, groundMask);
        if (hit)
        {
            // Debug.Log("Ground");
            canJump = true;
            // Debug.DrawLine(transform.position, hit.point, Color.red, jumpDistance);

        }
    

    // Update is called once per frame
  
   

        float h = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            fMove = -1;

            //transform.Translate(moveSpeed, 0, 0 * Time.fixedDeltaTime);

            myRigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, myRigidbody2D.velocity.y);


            isRight = true;

            isLeft = false; 
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            fMove = 1;

            //transform.Translate(-moveSpeed, 0, 0 * Time.fixedDeltaTime);

            myRigidbody2D.velocity = new Vector2(-Input.GetAxis("Horizontal") * -moveSpeed, myRigidbody2D.velocity.y);


            isLeft = true;

            isRight = false;

        }

        //Do Jump
        if (canJump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                canJump = false;

                jumpDistance = 0;

               // GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed * Time.deltaTime));

                myRigidbody2D.AddForce(new Vector2(0, jumpSpeed));
            }
        }



        if (fMove > 0 && isFacingRight)
        {
            Flip();
        }
        else if (fMove < 0 && !isFacingRight)
        {
            Flip();
        }


        helthBar.value = health;

        if (helthBar.value <= 0)
        {
            print("Game Over");

            //print(helthBar.value.ToString());

            helthBar.fillRect.GetComponent<Image>().gameObject.SetActive(false);
        }



    }

    void Flip()
    {
        isFacingRight = !isFacingRight;


        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            //print("Floor");

            jumpDistance = 3;
        }

        if (col.gameObject.tag == "Enemy")
        {
            //print("Enemy");

            health--;

            //Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
