using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointCount : MonoBehaviour
{
    public int Points;

    public Text enemyPointText;


   // EnemyMove eMove;

   // GameObject[] enOBJ;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Points <= 19)
        {

            enemyPointText.text = Points.ToString();
        }
        else if (Points >= 20)
        {
            enemyPointText.text = "WIN!";

        }
    }
}
