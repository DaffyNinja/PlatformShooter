using UnityEngine;
using System.Collections;

public class NewPlayerMove : MonoBehaviour
{

   // public Vector2 rightForce;

   // public Vector2 leftForce;

    //float pos;

    public float mSpeed;

    private Rigidbody2D myRigidbody;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            myRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * mSpeed, myRigidbody.velocity.y);

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
       

            myRigidbody.velocity = new Vector2(-Input.GetAxis("Horizontal") * -mSpeed, myRigidbody.velocity.y);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
