using UnityEngine;
using System.Collections;

public class MedKitPU : MonoBehaviour {

    public int healthAdd; 


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("MedKit");

            col.gameObject.GetComponent<PlayerMove>().health += 25;

            Destroy(this.gameObject);
        }
    }
}
