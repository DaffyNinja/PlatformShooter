using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointCount : MonoBehaviour
{
    public int Points;

    public Text enemyPointText;


    EnemySpawn eSpawn;

   // EnemyMove eMove;

   // GameObject[] enOBJ;

    private GameObject Door1;


    // Use this for initialization
    void Start()
    {
        eSpawn = this.gameObject.GetComponent<EnemySpawn>();

        Door1 = GameObject.Find("Door");
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
            //WIN

            eSpawn.canSpawn = false;

            Door1.SetActive(false);
           
            enemyPointText.text = "Door";

        }
    }
}
