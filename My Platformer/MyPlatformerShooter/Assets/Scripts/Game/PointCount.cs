using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointCount : MonoBehaviour
{
    public int Points;

    public Text enemyPointText;


    EnemySpawn eSpawn;


    public bool wonRound = false;


    // Use this for initialization
    void Start()
    {
        //eSpawn = this.gameObject.GetComponent<EnemySpawn>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //if (Points == 3)
        //{
        //    enemyPointText.text = "Open";


        //}

        if (Points <= 19)
        {
            enemyPointText.text = Points.ToString();
        }
        //else if (Points >= 20)
        //{
        //    enemyPointText.text = "Door";

        //    eSpawn.enabled = false;
        //}

        //if (Points >= 30)
        //{
        //    print("NEW WIN!!!");

        //}

    }
}
