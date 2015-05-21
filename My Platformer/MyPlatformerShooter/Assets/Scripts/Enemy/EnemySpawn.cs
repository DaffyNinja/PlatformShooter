using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{

    public float waveTime;

    float timer;

    public Transform[] spawnPos;

    public GameObject enemyOBJ;

    public bool canSpawn = true;

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < spawnPos.Length; i++)
        {
            Instantiate(enemyOBJ, spawnPos[i].transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canSpawn == true)
        {

            timer += Time.deltaTime;

            if (timer >= waveTime)
            {
                for (int i = 0; i < spawnPos.Length; i++)
                {
                    Instantiate(enemyOBJ, spawnPos[i].transform.position, Quaternion.identity);
                }

                timer = 0;

            }
        }

    }
}
