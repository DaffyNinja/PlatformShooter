using UnityEngine;
using System.Collections;

public class TrigTwo : MonoBehaviour {

    public GameObject Door;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("Trig 2");

            Door.SetActive(true);
        }
    }
}
