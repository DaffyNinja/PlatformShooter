using UnityEngine;
using System.Collections;

public class AmmoBoxPU : MonoBehaviour {

    public int addAmmo;

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
            //print("AmmoBox");

            col.gameObject.GetComponentInChildren<PlayerShoot>().ammoCount += addAmmo; 

            Destroy(this.gameObject);

        }
    }
}
