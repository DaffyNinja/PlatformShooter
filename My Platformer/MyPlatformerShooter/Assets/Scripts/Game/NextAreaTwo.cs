using UnityEngine;
using System.Collections;

public class NextAreaTwo : MonoBehaviour
{



    private GameObject Door2;

    private GameObject Door3;

    PointCount PC;

    EnemySpawn ESpawn;


    bool changeText;


    // Use this for initialization
    void Start()
    {
        PC = GameObject.Find("Game Master").GetComponent<PointCount>();

        ESpawn = this.gameObject.GetComponent<EnemySpawn>();


        Door2 = GameObject.Find("Door 2");

        Door3 = GameObject.Find("Door 3");


        ESpawn.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Door1 = GameObject.Find("Door");

        //Door1 = PC.Door1;

        if (changeText == true)
        {
            PC.enemyPointText.text = PC.Points.ToString();
        }

        if (PC.Points >= 30)
        {
            Door3.SetActive(false);

            ESpawn.enabled = false;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("Hit");

            changeText = true;


            Door2.SetActive(true);

            ESpawn.enabled = true;

            //ESpawn.canSpawn = true;

            // Door2.SetActive(false);
        }
    }
}
