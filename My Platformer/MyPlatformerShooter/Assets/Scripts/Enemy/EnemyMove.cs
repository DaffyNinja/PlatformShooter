using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{

    public float enemySpeed;

    bool moveRight;

    bool moveLeft;

    bool startMove = true;


  // public int enemyPoint;

    //bool addPoint;

    PointCount PointC;


    // Use this for initialization
    void Start()
    {
        //PointC = GameObject.Find("Game Master").GetComponent<PointCount>();

    }

    // Update is called once per frame
    void Update()
    {
        PointC = GameObject.Find("Game Master").GetComponent<PointCount>();
    }

   
    void FixedUpdate()
    {

        if (startMove == true)
        {
            transform.Translate(enemySpeed, 0, 0);
        }

        if (moveRight == true)
        {
            transform.Translate(enemySpeed, 0, 0);
        }
        else if (moveLeft == true)
        {
            transform.Translate(-enemySpeed, 0, 0);
        }

        //if (addPoint == true)
        //{
        //    enemyPoint++;

        //    addPoint = false;

        //}

        //print(enemyPoint.ToString());
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RW")
        {
            // print("Wall");

            startMove = false;

            moveLeft = true;

            moveRight = false;
        }

        if (col.gameObject.name == "LW")
        {
            //print("Wall");

            startMove = false;

            moveLeft = false;

            moveRight = true;
        }

        if (col.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (col.gameObject.tag == "Bullet")
        {

            //enemyPoint++;

            //addPoint = true;

            PointC.Points++;

            Destroy(this.gameObject);

            // enemyPoint++;

            //print(enemyPoint.ToString());


        }

    }
}
