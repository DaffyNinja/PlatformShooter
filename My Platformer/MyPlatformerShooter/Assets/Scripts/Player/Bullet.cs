﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed;

    public float lifeTime;

    float timer = 0;


    PlayerMove playerM;


    Vector3 velo;

    Vector3 pos;


    GameObject bulletParent;


    // Use this for initialization
    void Start()
    {
        bulletParent = GameObject.Find("Bullets Parent");

        this.gameObject.transform.parent = bulletParent.transform;


        playerM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();


        velo = new Vector3(bulletSpeed * Time.deltaTime, 0, 0);

        pos = transform.position;


        if (playerM.isRight == true)
        {
            velo = new Vector3(bulletSpeed * Time.deltaTime, 0, 0);
        }
        else if (playerM.isLeft == true)
        {
            velo = new Vector3(-bulletSpeed * Time.deltaTime, 0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {

        pos += velo;

        transform.position = pos;


        timer += Time.deltaTime;

        if (timer >= lifeTime)
        {
            Destroy(this.gameObject);

            timer = 0;
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //print("Hit");

        if (col.gameObject.tag == "Door")
        {
            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

        
    }

}
