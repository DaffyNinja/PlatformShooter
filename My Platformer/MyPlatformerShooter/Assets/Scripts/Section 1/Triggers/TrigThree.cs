using UnityEngine;
using System.Collections;

public class TrigThree : MonoBehaviour {

    TrigOne T1;

    bool Activated;

	// Use this for initialization
	void Start () 
    {
        T1 = GameObject.Find("Trig 4 ES").GetComponent<TrigOne>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Activated == true)
        {
            T1.nextDoor.SetActive(true);
        }
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Activated = true;
        }
        
    }
}
