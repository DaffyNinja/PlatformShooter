 using UnityEngine;
using System.Collections;

public class NextArea : MonoBehaviour {

    private GameObject Door1;

    private GameObject Door2;

    private GameObject Door3;

    PointCount PC;

	// Use this for initialization
	void Start ()
    {
        //Door1 = GameObject.Find("Door");

        Door2 = GameObject.Find("Door 2");

        Door3 = GameObject.Find("Door 3");

        PC = GameObject.Find("Game Master").GetComponent<PointCount>();

       // Door1 = PC.Door1;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Door1 = GameObject.Find("Door");

        //Door1 = PC.Door1;
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           // print("Hit");

            Door1.SetActive(true);

            Door2.SetActive(false);
        }
    }
}
