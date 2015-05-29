using UnityEngine;
using System.Collections;

public class TrigOne : MonoBehaviour {

    public int requiredPoints;

    public GameObject PreviousDoor;

    public GameObject nextDoor;

    EnemySpawn Es;

    PointCount Pc;

    bool nextStage;

   // public GameObject Trig5;

	// Use this for initialization
	void Start () 
    {
        Pc = GameObject.Find("Game Master").GetComponent<PointCount>();


        Es = this.gameObject.GetComponent<EnemySpawn>();

        Es.enabled = false;

	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Pc.Points == requiredPoints)
        {
            Es.enabled = false;

            print("Next Section");

            //nextStage = true;

            nextDoor.SetActive(false);

        }

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("Trig 1");

            Es.enabled = true;

            PreviousDoor.SetActive(true);


        }
    }
}
